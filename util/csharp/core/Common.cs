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
using AlibabaCloud.OSSUtil.Models;
using AlibabaCloud.OSSUtil.Streams;
using AlibabaCloud.OSSUtil.Utils;
using Tea;

namespace AlibabaCloud.OSSUtil
{
    public static class Common
    {
        private static readonly string _defaultUserAgent;

        private static readonly char[] characters = { '-', '_', '.', '~' };

        static Common()
        {
            _defaultUserAgent = GetDefaultUserAgent();
        }

        /// <summary>
        /// Get error message from msg
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public static Dictionary<string,object> GetErrMessage(string body)
        {
            return (Dictionary<string, object>)DictUtils.GetDicValue(XmlUtil.DeserializeXml(body, typeof(ServiceError)), "Error");
        }

        public static Dictionary<string, string> ToQuery(Dictionary<string, object> dicRequest)
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

        public static Dictionary<string, string> ToMeta(Dictionary<string, string> meta, string prefix)
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

        public static Dictionary<string, string> ParseMeta(Dictionary<string, string> meta, string prefix)
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

        public static string GetContentType(string filePath)
        {
            string type = Utils.MimeMapping.GetMimeMapping(filePath);
            if (string.IsNullOrWhiteSpace(type))
            {
                type = DictUtils.GetDicValue(StaticConst.extToMimeType, Path.GetExtension(filePath).ToLower());
            }
            return type;
        }

        public static string GetContentMD5(string str, bool? isEnableMD5)
        {
            if (isEnableMD5 == false)
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

        public static string Encode(string value, string encodeType)
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

        public static string GetUserAgent(string val)
        {
            if (!string.IsNullOrWhiteSpace(val))
            {
                return _defaultUserAgent + " " + val;
            }
            return _defaultUserAgent;
        }

        public static string GetHost(string bucketName,string regionId,string endpoint,string hostModel)
        {
            string host = string.Empty;
            if (string.IsNullOrWhiteSpace(regionId))
            {
                regionId = "cn-hangzhou";
            }
            if (string.IsNullOrWhiteSpace(endpoint))
            {
                endpoint = "oss-" + regionId + ".aliyuncs.com";
            }
            if (!string.IsNullOrWhiteSpace(bucketName))
            {
                hostModel = hostModel == null ? string.Empty : hostModel;
                if (hostModel.ToLower() == "ip")
                {
                    host = endpoint + "/" + bucketName;
                }
                else if (hostModel.ToLower() == "cname")
                {
                    host = endpoint;
                }
                else
                {
                    host = bucketName + "." + endpoint;
                }
            }
            else
            {
                host = endpoint;
            }
            return host;
        }

        public static Stream Inject(Stream body, Dictionary<string, string> dict)
        {
            return new VerifyStream(body, dict);
        }

        public static string GetSignature(TeaRequest request, string bucketName,string accessKeyId,string accessKeySecret,string signatureVersion,List<string> addtionalHeaders)
        {
            if (signatureVersion.ToLower() == "v2")
            {
                if (addtionalHeaders == null || addtionalHeaders.Count == 0)
                {
                    return "OSS2 AccessKeyId:" + accessKeyId + ",Signature:" + GetSignatureV2(request, bucketName, accessKeySecret, addtionalHeaders);
                }
                else
                {
                    return "OSS2 AccessKeyId:" + accessKeyId + ",AdditionalHeaders:" + string.Join(";", addtionalHeaders) + ",Signature:" + GetSignatureV2(request, bucketName, accessKeySecret, addtionalHeaders);
                }
            }
            else
            {
                return "OSS " + accessKeyId + ":" + GetSignatureV1(request, bucketName, accessKeySecret);
            }
        }

        public static string Decode(string val, string decodeType)
        {
            switch(decodeType)
            {
                case "Base64Decode": return Base64Decode(val);
                case "UrlDecode": return UrlDecode(val);
            }
            return val;
        }

        internal static string Base64Decode(string str)
        {
            string[] strs = str.Split('/');
            strs[strs.Length - 1] = Encoding.UTF8.GetString(Convert.FromBase64String(strs[strs.Length - 1]));
            return string.Join("/", strs);
        }

        internal static string UrlDecode(string str)
        {
            string[] strs = str.Split('/');
            strs[strs.Length - 1] = HttpUtility.UrlDecode(strs[strs.Length - 1], Encoding.UTF8);
            return string.Join("/", strs);
        }

        internal static string GetSignatureV1(TeaRequest teaRequest, string bucketName, string accessKeySecret)
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

        internal static string GetSignedStrV1(TeaRequest teaRequest, string canonicalizedResource, string accessKeySecret)
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
            using (KeyedHashAlgorithm algorithm = CryptoConfig.CreateFromName("HMACSHA1") as KeyedHashAlgorithm)
            {
                algorithm.Key = Encoding.UTF8.GetBytes(accessKeySecret);
                signData = algorithm.ComputeHash(Encoding.UTF8.GetBytes(signStr.ToCharArray()));
            }
            string signedStr = Convert.ToBase64String(signData);

            return signedStr;
        }

        internal static string GetSignatureV2(TeaRequest teaRequest, string bucketName, string accessKeySecret, List<string> additionalHeaders)
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

        internal static string GetSignedStrV2(TeaRequest teaRequest, string canonicalizedResource, string accessKeySecret, List<string> additionalHeaders)
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
            using (KeyedHashAlgorithm algorithm = CryptoConfig.CreateFromName("HMACSHA256") as KeyedHashAlgorithm)
            {
                algorithm.Key = Encoding.UTF8.GetBytes(accessKeySecret);
                signData = algorithm.ComputeHash(Encoding.UTF8.GetBytes(signStr.ToCharArray()));
            }
            string signedStr = Convert.ToBase64String(signData);
            return signedStr;
        }

        internal static string UriEncode(string rawStr, bool? encodeSlash)
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
                    if (encodeSlash == true)
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
                    res = res + "%" + ((int)ch).ToString("X2");
                }
            }
            return res;
        }

        internal static string GetDefaultUserAgent()
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

        internal static string GetRuntimeRegexValue(string value)
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

        internal static string BuildClientVersion(string[] value)
        {
            var finalValue = "";
            for (var i = 0; i < value.Length - 1; ++i)
            {
                finalValue += value[i].Replace(".", "").ToLower();
            }

            finalValue += "/" + value[value.Length - 1];

            return finalValue;
        }
    }
}
