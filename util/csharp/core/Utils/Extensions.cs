using System;

namespace AlibabaCloud.OSSUtil.Utils
{
    internal static class Extensions
    {
        internal static string ToSafeString(this object obj, string defaultStr = null)
        {
            try
            {
                return obj.ToString();
            }
            catch
            {
                return defaultStr;
            }
        }

        internal static bool ToSafeBool(this object obj, bool defaultBool = false)
        {
            try
            {
                return Convert.ToBoolean(obj);
            }
            catch
            {
                return defaultBool;
            }
        }

        internal static int? ToSafeInt32(this object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return null;
            }
        }

        internal static int ToSafeInt32(this object obj, int defaultInt)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return defaultInt;
            }
        }

    }
}
