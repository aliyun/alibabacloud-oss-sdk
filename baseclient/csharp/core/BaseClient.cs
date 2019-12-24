// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

using AlibabaCloud.OSS.Models;
using AlibabaCloud.OSS.Streams;
using AlibabaCloud.OSS.Utils;

using Aliyun.Credentials;
using Aliyun.Credentials.Utils;

using Newtonsoft.Json;

using Tea;

namespace AlibabaCloud.OSS
{
    public class BaseClient
    {
        protected string _regionId;
        protected string _endpoint;
        protected string _protocol;
        protected readonly string _defaultUserAgent;
        protected string _userAgent;
        protected string _hostModel;
        protected bool _isEnableMD5;
        protected bool _isEnableCrc;
        protected int? _readTimeout;
        protected int? _connectTimeout;
        protected string _localAddr;
        protected string _httpProxy;
        protected string _httpsProxy;
        protected string _noProxy;
        protected string _socks5Proxy;
        protected string _socks5NetWork;
        protected int? _maxIdleConns;
        protected object _logger;
        protected Dictionary<string, object> _config;
        protected List<string> _addtionalHeaders;
        protected string _signatureVersion;

        internal Credential credential;

        private char[] characters = { '-', '_', '.', '~' };

        public string SignatureVersion
        {
            get
            {
                return _signatureVersion;
            }
            set
            {
                _signatureVersion = value;
            }
        }

        public List<string> AddtionalHeaders
        {
            get
            {
                return _addtionalHeaders;
            }
            set
            {
                _addtionalHeaders = value;
            }
        }

        public BaseClient(Dictionary<string, object> config)
        {
            _regionId = DictUtils.GetDicValue(config, "regionId").ToSafeString();
            _protocol = DictUtils.GetDicValue(config, "protocol").ToSafeString();
            _endpoint = DictUtils.GetDicValue(config, "endpoint").ToSafeString();
            _signatureVersion = DictUtils.GetDicValue(config, "signatureVersion").ToSafeString();
            _hostModel = DictUtils.GetDicValue(config, "hostModel").ToSafeString();
            _isEnableMD5 = DictUtils.GetDicValue(config, "isEnableMD5").ToSafeBool();
            _isEnableCrc = DictUtils.GetDicValue(config, "isEnableCrc").ToSafeBool();
            _readTimeout = DictUtils.GetDicValue(config, "readTimeout").ToSafeInt32();
            _connectTimeout = DictUtils.GetDicValue(config, "connectTimeout").ToSafeInt32();
            _localAddr = DictUtils.GetDicValue(config, "localAddr").ToSafeString();
            _httpProxy = DictUtils.GetDicValue(config, "httpProxy").ToSafeString();
            _httpsProxy = DictUtils.GetDicValue(config, "httpsProxy").ToSafeString();
            _noProxy = DictUtils.GetDicValue(config, "noProxy").ToSafeString();
            _socks5Proxy = DictUtils.GetDicValue(config, "socks5Proxy").ToSafeString();
            _socks5NetWork = DictUtils.GetDicValue(config, "socks5NetWork").ToSafeString();
            _maxIdleConns = DictUtils.GetDicValue(config, "maxIdleConns").ToSafeInt32();
            AddtionalHeaders = (List<string>) DictUtils.GetDicValue(config, "addtionalHeaders");
            _config = config;
            _defaultUserAgent = GetDefaultUserAgent();

            SetCredential(config);
        }

        protected void SetCredential(Dictionary<string, object> config)
        {
            Configuration credentialConfig = new Configuration()
            {
                AccessKeyId = DictUtils.GetDicValue(config, "accessKeyId").ToSafeString(),
                AccessKeySecret = DictUtils.GetDicValue(config, "accessKeySecret").ToSafeString(),
                SecurityToken = DictUtils.GetDicValue(config, "securityToken").ToSafeString(),
                Type = DictUtils.GetDicValue(config, "type").ToSafeString()
            };
            if (string.IsNullOrWhiteSpace(credentialConfig.Type))
            {
                credentialConfig.Type = AuthConstant.AccessKey;
            }
            credential = new Credential(credentialConfig);
        }

        protected string _getDate()
        {
            return DateTime.UtcNow.ToUniversalTime().GetDateTimeFormats('r') [0];
        }

        protected Dictionary<string, object> _parseXml(string content, Type type)
        {
            return XmlUtil.DeserializeXml(content, type);
        }

        protected string _getHost(string bucketName)
        {
            string host = string.Empty;
            if (string.IsNullOrWhiteSpace(_regionId))
            {
                _regionId = "cn-hangzhou";
            }
            if (string.IsNullOrWhiteSpace(_endpoint))
            {
                _endpoint = "oss-" + _regionId + ".aliyuncs.com";
            }
            if (!string.IsNullOrWhiteSpace(bucketName))
            {
                _hostModel = _hostModel == null?string.Empty : _hostModel;
                if (_hostModel.ToLower() == "ip")
                {
                    host = _endpoint + "/" + bucketName;
                }
                else if (_hostModel.ToLower() == "cname")
                {
                    host = _endpoint;
                }
                else
                {
                    host = bucketName + "." + _endpoint;
                }
            }
            else
            {
                host = _endpoint;
            }
            return host;
        }

        public string _default(string strValue, string strDefault)
        {
            if (string.IsNullOrWhiteSpace(strValue))
            {
                return strDefault;
            }
            return strValue;
        }

        public int? _defaultNumber(int? numValue, int? numDefault)
        {
            if (numValue > 0)
            {
                return numValue;
            }
            return numDefault;
        }

        protected string _toXML(object obj)
        {
            return XmlUtil.SerializeXml(obj);
        }

        protected bool _isFail(TeaResponse teaResponse)
        {
            if (teaResponse.StatusCode >= 200 && teaResponse.StatusCode < 300)
            {
                return false;
            }

            return true;
        }

        protected Dictionary<string, string> _toQuery(Dictionary<string, object> dicRequest)
        {
            Dictionary<string, string> dicQuery = new Dictionary<string, string>();
            foreach (KeyValuePair<string, object> item in dicRequest)
            {
                if (item.Value != null)
                {
                    dicQuery.Add(item.Key, item.Value.ToString());
                }
            }
            return dicQuery;
        }

        protected Dictionary<string, string> _toMeta(Dictionary<string, string> meta, string prefix)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (meta == null)
            {
                return result;
            }
            foreach (var keypair in meta)
            {
                string newKey = keypair.Key;
                if (!keypair.Key.ToLower().StartsWith(prefix))
                {
                    newKey = prefix + keypair.Key;
                }
                result.Add(newKey, keypair.Value.ToSafeString());
            }
            return result;
        }

        protected Dictionary<string, string> _parseMeta(Dictionary<string, string> meta, string prefix)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (meta == null)
            {
                return result;
            }
            foreach (var keypair in meta)
            {
                string newKey = keypair.Key;
                if (keypair.Key.ToLower().StartsWith(prefix))
                {
                    newKey = keypair.Key.Replace(prefix, "");
                }
                result.Add(newKey, keypair.Value.ToSafeString());
            }
            return result;
        }

        protected string _getContentMD5(string str)
        {
            if (!_isEnableMD5)
            {
                return string.Empty;
            }
            try
            {
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
                return Convert.ToBase64String(data);
            }
            catch
            {
                return string.Empty;
            }

        }

        protected string _getContentLength(TeaRequest teaRequest, string length)
        {
            if (!string.IsNullOrWhiteSpace(length))
            {
                return length;
            }
            return teaRequest.Body.Length.ToString();
        }

        protected string _getSpecialValue(object obj, string key)
        {
            Dictionary<string, string> ditc;

            string jsonStr = JsonConvert.SerializeObject(obj);
            ditc = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonStr);
            return DictUtils.GetDicValue(ditc, key);

        }

        protected string _getContentType(string filePath)
        {
            string type = Utils.MimeMapping.GetMimeMapping(filePath);
            if (string.IsNullOrWhiteSpace(type))
            {
                type = DictUtils.GetDicValue(StaticConst.extToMimeType, Path.GetExtension(filePath).ToLower());
            }
            return type;
        }

        protected bool _isNotCrcMatched(ulong? reqCrc, string respCrc)
        {
            if (_isEnableCrc)
            {
                if (!string.IsNullOrWhiteSpace(respCrc))
                {
                    return reqCrc == Convert.ToUInt64(respCrc);
                }
            }
            return false;
        }

        protected string _encode(string value, string encodeType)
        {
            string[] strs = value.Split('/');
            switch (encodeType)
            {
                case "Base64":
                    strs[strs.Length - 1] = Convert.ToBase64String(Encoding.UTF8.GetBytes(strs[strs.Length - 1]));
                    break;
                case "UrlEncode":
                    strs[strs.Length - 1] = HttpUtility.UrlEncode(strs[strs.Length - 1], Encoding.UTF8);
                    break;
            }
            value = string.Join("/", strs);
            return value;
        }

        protected string _base64Decode(string str)
        {
            string[] strs = str.Split('/');
            strs[strs.Length - 1] = Encoding.UTF8.GetString(Convert.FromBase64String(strs[strs.Length - 1]));
            return string.Join("/", strs);
        }

        protected string _urlDecode(string str)
        {
            string[] strs = str.Split('/');
            strs[strs.Length - 1] = HttpUtility.UrlDecode(strs[strs.Length - 1], Encoding.UTF8);
            return string.Join("/", strs);
        }

        protected ulong _parseUint(string respCrc, bool hasRange)
        {
            if (hasRange)
            {
                return 0;
            }
            try
            {
                return Convert.ToUInt64(respCrc);
            }
            catch
            {
                return 0;
            }
        }

        public void _appendUserAgent(string userAgent)
        {
            if (!string.IsNullOrWhiteSpace(userAgent))
            {
                this._userAgent += " " + userAgent;
            }
        }

        public void _setUserAgent(string userAgent)
        {
            this._userAgent = userAgent;
        }

        public string _getUserAgent()
        {
            if (!string.IsNullOrWhiteSpace(this._userAgent))
            {
                return _defaultUserAgent + " " + this._userAgent;
            }
            return _defaultUserAgent;
        }

        protected Dictionary<string, object> _getErrMessage(string body)
        {
            return (Dictionary<string, object>) DictUtils.GetDicValue(XmlUtil.DeserializeXml(body, typeof(ServiceError)), "Error");
        }

        protected Dictionary<string, string> _toHeader(Dictionary<string, object> headers)
        {
            Dictionary<string, string> dicHeaders = new Dictionary<string, string>();
            foreach (KeyValuePair<string, object> item in headers)
            {
                if (item.Value != null)
                {
                    dicHeaders.Add(item.Key, item.Value.ToString());
                }
            }
            return dicHeaders;
        }

        protected Stream _readAsStream(TeaResponse teaResponse)
        {
            return teaResponse.Body;
        }

        protected string _readAsString(TeaResponse teaResponse)
        {
            string bodyStr = TeaCore.GetResponseBody(teaResponse);
            return bodyStr;
        }

        protected string _listToString(List<string> str, string sep)
        {
            return string.Join(sep, str);
        }

        protected bool _equal(string val1, string val2)
        {
            return val1 == val2;
        }

        protected bool _empty(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        protected string _getAccessKeyID()
        {
            if (credential == null)
            {
                throw new ArgumentNullException("No credential valid!");
            }
            return credential.AccessKeyId;
        }

        protected string _getAccessKeySecret()
        {
            if (credential == null)
            {
                throw new ArgumentNullException("No credential valid!");
            }
            return credential.AccessKeySecret;
        }

        protected string _getSecurityToken()
        {
            if (credential == null)
            {
                throw new ArgumentNullException("No credential valid!");
            }
            return credential.SecurityToken;
        }

        protected bool _ifListEmpty(List<string> strs)
        {
            return strs == null || strs.Count == 0;
        }

        protected bool _notNull(Dictionary<string, object> obj)
        {
            return obj != null && obj.Count > 0;
        }

        protected Stream _inject(Stream body, Dictionary<string, string> dict)
        {
            return new VerifyStream(body, dict);
        }

        internal string GetDefaultUserAgent()
        {
            string defaultUserAgent = string.Empty;
            string OSVersion = Environment.OSVersion.ToString();
            string ClientVersion = GetRuntimeRegexValue(RuntimeEnvironment.GetRuntimeDirectory());
            string CoreVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            defaultUserAgent = "Alibaba Cloud (" + OSVersion + ") ";
            defaultUserAgent += ClientVersion;
            defaultUserAgent += " Core/" + CoreVersion;
            return defaultUserAgent;
        }

        internal string GetRuntimeRegexValue(string value)
        {
            var rx = new Regex(@"(\.NET).*(\\|\/).*(\d)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = rx.Match(value);
            char[] separator = { '\\', '/' };

            if (matches.Success)
            {
                var clientValueArray = matches.Value.Split(separator);
                return BuildClientVersion(clientValueArray);
            }

            return "RuntimeNotFound";
        }

        internal string BuildClientVersion(string[] value)
        {
            var finalValue = "";
            for (var i = 0; i < value.Length - 1; ++i)
            {
                finalValue += value[i].Replace(".", "").ToLower();
            }

            finalValue += "/" + value[value.Length - 1];

            return finalValue;
        }

        protected string _getSignatureV1(TeaRequest teaRequest, string bucketName, string accessKeySecret)
        {
            string resource = string.Empty;
            if (!string.IsNullOrWhiteSpace(bucketName))
            {
                resource = "/" + bucketName;
            }

            resource = resource + teaRequest.Pathname;

            if (teaRequest.Query.Count > 0 && !resource.Contains('?'))
            {
                resource += "?";
            }

            foreach (var keypair in teaRequest.Query)
            {
                if (StaticConst.signKeyList.Contains(keypair.Key) && !string.IsNullOrWhiteSpace(keypair.Value))
                {
                    if (resource.EndsWith("?"))
                    {
                        resource = resource + keypair.Key + "=" + keypair.Value;
                    }
                    else
                    {
                        resource = resource + "&" + keypair.Key + "=" + keypair.Value;
                    }
                }
            }

            return GetSignedStrV1(teaRequest, resource, accessKeySecret);
        }

        internal string GetSignedStrV1(TeaRequest teaRequest, string canonicalizedResource, string accessKeySecret)
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();

            foreach (var keypair in teaRequest.Headers)
            {
                if (keypair.Key.ToLower().StartsWith("x-oss-"))
                {
                    temp.Add(keypair.Key.ToLower(), keypair.Value);
                }
            }

            Dictionary<string, string> hs = (from dic in temp orderby dic.Key ascending select dic).ToDictionary(p => p.Key, o => o.Value);
            string canonicalizedOSSHeaders = string.Empty;
            foreach (var keypair in hs)
            {
                canonicalizedOSSHeaders += keypair.Key + ":" + keypair.Value + "\n";
            }
            string date = DictUtils.GetDicValue(teaRequest.Headers, "date");
            string contentType = DictUtils.GetDicValue(teaRequest.Headers, "content-type");
            string contentMd5 = DictUtils.GetDicValue(teaRequest.Headers, "content-md5");
            string signStr = teaRequest.Method + "\n" + contentMd5 + "\n" + contentType + "\n" + date + "\n" + canonicalizedOSSHeaders + canonicalizedResource;
            System.Diagnostics.Debug.WriteLine(signStr);
            byte[] signData;
            using(KeyedHashAlgorithm algorithm = CryptoConfig.CreateFromName("HMACSHA1") as KeyedHashAlgorithm)
            {
                algorithm.Key = Encoding.UTF8.GetBytes(accessKeySecret);
                signData = algorithm.ComputeHash(Encoding.UTF8.GetBytes(signStr.ToCharArray()));
            }
            string signedStr = Convert.ToBase64String(signData);

            return signedStr;
        }

        protected string _getSignatureV2(TeaRequest teaRequest, string bucketName, string accessKeySecret, List<string> additionalHeaders)
        {
            if (additionalHeaders == null)
            {
                additionalHeaders = new List<string>();
            }
            string resource = string.Empty;
            string pathName = teaRequest.Pathname;
            if (!string.IsNullOrWhiteSpace(bucketName))
            {
                pathName = "/" + bucketName + pathName;
            }

            Dictionary<string, string> sortDict = new Dictionary<string, string>(teaRequest.Query);
            string[] strs = pathName.Split('?');
            resource += UriEncode(strs[0], true);
            if (strs.Length > 1 && !string.IsNullOrWhiteSpace(strs[1]))
            {
                sortDict.Add(strs[1], string.Empty);
            }

            Dictionary<string, string> hs = new Dictionary<string, string>();

            hs = (from dic in sortDict orderby dic.Key ascending select dic).ToDictionary(p => p.Key, o => o.Value);

            if (hs.Count > 0 && !resource.Contains("?"))
            {
                resource += "?";
            }
            foreach (var keypair in hs)
            {
                if (!resource.EndsWith("?"))
                {
                    resource += "&";
                }
                if (!string.IsNullOrEmpty(keypair.Value))
                {
                    resource += UriEncode(keypair.Key, true) + "=" + UriEncode(keypair.Value, true);
                }
                else
                {
                    resource += UriEncode(keypair.Key, true);
                }
            }

            return GetSignedStrV2(teaRequest, resource, accessKeySecret, additionalHeaders);
        }

        internal string GetSignedStrV2(TeaRequest teaRequest, string canonicalizedResource, string accessKeySecret, List<string> additionalHeaders)
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();

            foreach (var keypair in teaRequest.Headers)
            {
                if ((from k in additionalHeaders where k.ToLower() == keypair.Key.ToLower() select k).ToList().Count() > 0)
                {
                    temp.Add(keypair.Key.ToLower(), keypair.Value);
                }
                else if (keypair.Key.ToLower().StartsWith("x-oss-"))
                {
                    temp.Add(keypair.Key.ToLower(), keypair.Value);
                }
            }

            Dictionary<string, string> hs = (from dic in temp orderby dic.Key ascending select dic).ToDictionary(p => p.Key, o => o.Value);
            string canonicalizedOSSHeaders = string.Empty;
            foreach (var keypair in hs)
            {
                canonicalizedOSSHeaders += keypair.Key + ":" + keypair.Value + "\n";
            }
            string date = DictUtils.GetDicValue(teaRequest.Headers, "date");
            string contentType = DictUtils.GetDicValue(teaRequest.Headers, "content-type");
            string contentMd5 = DictUtils.GetDicValue(teaRequest.Headers, "content-md5");
            string signStr = teaRequest.Method + "\n" + contentMd5 + "\n" + contentType + "\n" + date + "\n" + canonicalizedOSSHeaders + string.Join(";", additionalHeaders) + "\n" + canonicalizedResource;
            byte[] signData;
            using(KeyedHashAlgorithm algorithm = CryptoConfig.CreateFromName("HMACSHA256") as KeyedHashAlgorithm)
            {
                algorithm.Key = Encoding.UTF8.GetBytes(accessKeySecret);
                signData = algorithm.ComputeHash(Encoding.UTF8.GetBytes(signStr.ToCharArray()));
            }
            string signedStr = Convert.ToBase64String(signData);
            return signedStr;
        }

        internal string UriEncode(string rawStr, bool encodeSlash)
        {
            string res = string.Empty;
            foreach (char ch in rawStr)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') ||
                    (ch >= '0' && ch <= '9') || characters.Contains(ch))
                {
                    res += ch;
                }
                else if (ch == '/')
                {
                    if (encodeSlash)
                    {
                        res += "%2F";
                    }
                    else
                    {
                        res += ch;
                    }
                }
                else
                {
                    res = res + "%" + ((int) ch).ToString("X2");
                }
            }
            return res;
        }

    }
}
