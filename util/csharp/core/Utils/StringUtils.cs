namespace AlibabaCloud.OSSUtil.Utils
{
    internal static class StringUtils
    {
        internal static int SubStringCount(string str, string subString)
        {
            if (str.Contains(subString))
            {
                string strReplaced = str.Replace(subString, "");
                return (str.Length - strReplaced.Length) / subString.Length;
            }
            return 0;
        }
    }
}
