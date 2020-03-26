<?php

namespace AlibabaCloud\Tea\OSSUtils;

use Adbar\Dot;
use AlibabaCloud\Tea\Request;

class OSSUtils
{
    const SIGN_KEY_LIST = [
        'location',
        'cors',
        'objectMeta',
        'uploadId',
        'partNumber',
        'security-token',
        'position',
        'img',
        'style',
        'styleName',
        'replication',
        'replicationProgress',
        'replicationLocation',
        'cname',
        'qos',
        'startTime',
        'endTime',
        'symlink',
        'x-oss-process',
        'response-content-type',
        'response-content-language',
        'response-expires',
        'response-cache-control',
        'response-content-disposition',
        'response-content-encoding',
        'udf',
        'udfName',
        'udfImage',
        'udfId',
        'udfImageDesc',
        'udfApplication',
        'udfApplicationLog',
        'restore',
        'callback',
        'callback-var',
        'policy',
        'encryption',
        'versions',
        'versioning',
        'versionId',
    ];
    private static $defaultUserAgent = '';

    /**
     * @param string $msg
     *
     * @return array
     */
    public static function getErrMessage($msg)
    {
        $data = self::parseXml($msg);

        return $data['Error'];
    }

    /**
     * @param array  $val
     * @param string $prefix
     *
     * @return array
     */
    public static function toMeta($val, $prefix)
    {
        if (empty($val)) {
            return [];
        }
        $res = [];
        foreach ($val as $k => $v) {
            $newKey = strtolower($k);
            if (0 !== strpos($k, $prefix)) {
                $newKey = $prefix . $newKey;
            }
            $res[$newKey] = $v;
        }

        return $res;
    }

    public static function parseMeta($val, $prefix)
    {
        if (empty($val)) {
            return [];
        }
        $res = [];
        foreach ($val as $k => $v) {
            $newKey = strtolower($k);
            if (0 === strpos($newKey, $prefix)) {
                $newKey = str_replace($prefix, '', $newKey);
            }
            $res[$newKey] = $v;
        }

        return $res;
    }

    public static function getContentType($fileName)
    {
        $mimes = new \Mimey\MimeTypes();
        $ext   = pathinfo($fileName, PATHINFO_EXTENSION);

        return $mimes->getMimeType($ext);
    }

    public static function getContentMD5($body, $isEnableMD5)
    {
        if (false === $isEnableMD5) {
            return '';
        }

        return base64_encode(md5($body, true));
    }

    public static function encode($val, $encodeType)
    {
        $strs = explode('/', $val);
        $len  = \count($strs);
        switch ($encodeType) {
            case 'Base64':
                $strs[$len - 1] = base64_encode($strs[$len - 1]);

                break;
            case 'UrlEncode':
                $strs[$len - 1] = rawurlencode($strs[$len - 1]);

                break;
        }

        return implode('/', $strs);
    }

    public static function getUserAgent($val)
    {
        if (empty($val)) {
            return self::getDefaultUserAgent();
        }

        return self::getDefaultUserAgent() . ' ' . $val;
    }

    public static function getHost($bucketName, $regionId, $endpoint, $hostModel)
    {
        if (empty(trim($regionId))) {
            $regionId = 'cn-hangzhou';
        }
        if (empty(trim($endpoint))) {
            $endpoint = 'oss-' . $regionId . '.aliyuncs.com';
        }
        if (!empty($bucketName)) {
            $hostModel = null === $hostModel ? '' : $hostModel;
            if ('ip' === $hostModel) {
                $host = $endpoint . '/' . $bucketName;
            } elseif ('cname' == $hostModel) {
                $host = $endpoint;
            } else {
                $host = $bucketName . '.' . $endpoint;
            }
        } else {
            $host = $endpoint;
        }

        return $host;
    }

    /**
     * @param resource $body
     * @param array    $res
     *
     * @return VerifyStream
     */
    public static function inject($body, &$res)
    {
        return new VerifyStream($body, $res);
    }

    /**
     * @param Request  $request
     * @param string   $bucketName
     * @param string   $accessKeyId
     * @param string   $accessKeySecret
     * @param string   $signatureVersion
     * @param string[] $addtionalHeaders
     *
     * @return string
     */
    public static function getSignature($request, $bucketName, $accessKeyId, $accessKeySecret, $signatureVersion, $addtionalHeaders)
    {
        $signatureVersion = strtolower($signatureVersion);
        if ('v2' === $signatureVersion) {
            if (empty($addtionalHeaders)) {
                return 'OSS2 AccessKeyId:' . $accessKeyId .
                    ',Signature:' . self::getSignatureV2($request, $bucketName, $accessKeySecret, $addtionalHeaders);
            }

            return 'OSS2 AccessKeyId:' . $accessKeyId .
                    ',AdditionalHeaders:' . implode(';', $addtionalHeaders) .
                    ',Signature:' . self::getSignatureV2($request, $bucketName, $accessKeySecret, $addtionalHeaders);
        }

        return 'OSS ' . $accessKeyId . ':' . self::getSignatureV1($request, $bucketName, $accessKeySecret);
    }

    /**
     * @param string $val
     * @param string $decodeType
     *
     * @return string
     */
    public static function decode($val, $decodeType)
    {
        switch ($decodeType) {
            case 'Base64Decode':
                $res = base64_decode($val);

                return false === $res ? '' : $res;
            case 'UrlDecode':
                return rawurldecode($val);
        }

        return $val;
    }

    private static function parseXml($xmlStr)
    {
        libxml_disable_entity_loader(true);
        $xml      = simplexml_load_string($xmlStr, 'SimpleXMLElement', LIBXML_NOCDATA);
        $rootName = $xml->getName();

        return [
            $rootName => json_decode(
                json_encode(
                    $xml
                ),
                true
            ),
        ];
    }

    private static function getDefaultUserAgent()
    {
        if (empty(self::$defaultUserAgent)) {
            self::$defaultUserAgent = 'Alibaba Cloud (' . PHP_OS . ') ';
            self::$defaultUserAgent .= 'TeaCore/3';
        }

        return self::$defaultUserAgent;
    }

    /**
     * @param Request $request
     * @param string  $bucketName
     * @param string  $accessKeySecret
     *
     * @return string
     */
    private static function getSignatureV1($request, $bucketName, $accessKeySecret)
    {
        $canonicalizeResource = '';
        if (!empty($bucketName)) {
            $canonicalizeResource = '/' . $bucketName;
        }
        $canonicalizeResource .= $request->pathname;

        $query = $request->query;
        ksort($query);

        if (!empty($query)) {
            if (false === strpos($canonicalizeResource, '?')) {
                $canonicalizeResource .= '?';
            }
            foreach ($query as $k => $v) {
                if (\in_array($k, self::SIGN_KEY_LIST) && null !== $v && '' !== $v) {
                    if ('?' === $canonicalizeResource[\strlen($canonicalizeResource) - 1]) {
                        $canonicalizeResource .= $k . '=' . $v;
                    } else {
                        $canonicalizeResource .= '&' . $k . '=' . $v;
                    }
                }
            }
        }

        $headers    = new Dot($request->headers);
        $signString = implode("\n", [
            strtoupper($request->method),
            $headers->get('content-md5', ''),
            $headers->get('content-type', ''),
            $headers->get('date', ''),
            implode("\n", self::getCanonicalizeHeaders($request->headers)),
            $canonicalizeResource,
        ]);

        return base64_encode(
            hash_hmac(
                'sha1',
                $signString,
                $accessKeySecret,
                true
            )
        );
    }

    /**
     * @param Request  $request
     * @param string   $bucketName
     * @param string   $accessKeySecret
     * @param string[] $addtionalHeaders
     *
     * @return string
     */
    private static function getSignatureV2($request, $bucketName, $accessKeySecret, $addtionalHeaders)
    {
        if (empty($addtionalHeaders)) {
            $addtionalHeaders = [];
        }
        $canonicalizeResource = '';

        $pathname = $request->pathname;
        if (!empty($bucketName)) {
            $pathname = '/' . $bucketName . $pathname;
        }
        $tmp                  = explode('?', $pathname);
        $canonicalizeResource .= rawurlencode($tmp[0]);
        $sortDict             = $request->query;
        if (\count($tmp) > 1 && !empty($tmp[1])) {
            $sortDict[$tmp[1]] = '';
        }
        ksort($sortDict);
        if (\count($sortDict) > 0 && false === strpos($canonicalizeResource, '?')) {
            $canonicalizeResource .= '?';
        }

        $flag = '?' === $canonicalizeResource[\strlen($canonicalizeResource) - 1];

        foreach ($sortDict as $k => $v) {
            if (!$flag) {
                $canonicalizeResource .= '&';
            } else {
                $flag = false;
            }
            if (!empty($v)) {
                $canonicalizeResource .= rawurlencode($k) . '=' . rawurlencode($v);
            } else {
                $canonicalizeResource .= rawurlencode($k);
            }
        }

        $headers    = [];
        $headerKeys = [];
        foreach ($request->headers as $k => $v) {
            $key = strtolower($k);
            if (0 === strpos($key, 'x-oss-')) {
                $headers[$key] = $v;
            }
            $headerKeys[$key] = $k;
        }
        foreach ($addtionalHeaders as $header) {
            $header = strtolower($header);
            if (isset($headerKeys[$header]) && !isset($headers[$header])) {
                $headers[$header] = $request->headers[$headerKeys[$header]];
            }
        }
        $requestHeaders = new Dot($request->headers);
        $signString     = implode("\n", [
            strtoupper($request->method),
            $requestHeaders->get('content-md5', ''),
            $requestHeaders->get('content-type', ''),
            $requestHeaders->get('date', ''),
            implode("\n", self::getCanonicalizeHeaders($headers)),
            implode(';', $addtionalHeaders),
            $canonicalizeResource,
        ]);

        return base64_encode(
            hash_hmac(
                'sha256',
                $signString,
                $accessKeySecret,
                true
            )
        );
    }

    /**
     * @param array $headers
     *
     * @return array
     */
    private static function getCanonicalizeHeaders($headers)
    {
        $canonicalizeHeaders = [];
        foreach ($headers as $k => $v) {
            $headerName = strtolower($k);
            if (0 === strpos($headerName, 'x-oss-')) {
                array_push($canonicalizeHeaders, $headerName . ':' . $v);
            }
        }
        ksort($canonicalizeHeaders);

        return $canonicalizeHeaders;
    }
}
