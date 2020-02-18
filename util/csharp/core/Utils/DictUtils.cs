using System.Collections.Generic;

namespace AlibabaCloud.OSSUtil.Utils
{
    internal class DictUtils
    {
        internal static object GetDicValue(Dictionary<string, object> dic, string keyName)
        {
            if (dic != null && dic.ContainsKey(keyName))
            {
                return dic[keyName];
            }
            return null;
        }

        internal static string GetDicValue(Dictionary<string, string> dic, string keyName)
        {
            if (dic != null && dic.ContainsKey(keyName))
            {
                return dic[keyName];
            }
            return null;
        }
    }
}
