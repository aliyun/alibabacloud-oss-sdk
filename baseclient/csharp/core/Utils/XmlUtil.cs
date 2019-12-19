using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

using Tea;

namespace AlibabaCloud.OSS.Utils
{
    internal class XmlUtil
    {
        internal static Dictionary<string, object> DeserializeXml(string xmlStr, Type type)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            XmlDocument contentXmlDoc = new XmlDocument();
            contentXmlDoc.LoadXml(xmlStr);

            XmlNodeList nodeList = contentXmlDoc.ChildNodes;
            for (int i = 0; i < nodeList.Count; i++)
            {
                XmlNode root = nodeList.Item(i);
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo p in properties)
                {
                    Type propertyType = p.PropertyType;
                    NameInMapAttribute attribute = p.GetCustomAttribute(typeof(NameInMapAttribute)) as NameInMapAttribute;
                    string realName = attribute == null ? p.Name : attribute.Name;
                    if (root.Name == realName)
                    {
                        if (!typeof(TeaModel).IsAssignableFrom(propertyType))
                        {
                            result.Add(realName, root.InnerText);
                        }
                        else
                        {
                            result.Add(realName, getDictFromXml(root, propertyType));
                        }
                    }
                }
            }

            return result;
        }

        private static Dictionary<string, object> getDictFromXml(XmlNode element, Type type)
        {
            Dictionary<string, object> nodeDict = new Dictionary<string, object>();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo p = properties[i];
                Type propertyType = p.PropertyType;
                NameInMapAttribute attribute = p.GetCustomAttribute(typeof(NameInMapAttribute)) as NameInMapAttribute;
                string realName = attribute == null ? p.Name : attribute.Name;
                XmlNodeList node = element.SelectNodes(realName);

                if (node != null && node.Count > 0 && StringUtils.SubStringCount(node[0].OuterXml, realName) > 1)
                {
                    if (typeof(IList).IsAssignableFrom(propertyType))
                    {
                        Type innerPropertyType = propertyType.GetGenericArguments() [0];
                        if (typeof(TeaModel).IsAssignableFrom(innerPropertyType))
                        {
                            IList dicList = new List<Dictionary<string, object>>();
                            for (int j = 0; j < node.Count; j++)
                            {
                                dicList.Add(getDictFromXml(node.Item(j), innerPropertyType));
                            }
                            nodeDict.Add(realName, dicList);
                        }
                        else
                        {
                            var dicList = (IList) Activator.CreateInstance(propertyType);
                            for (int j = 0; j < node.Count; j++)
                            {
                                var value = mapObj(innerPropertyType, node.Item(j).InnerText);
                                dicList.Add(value);
                            }
                            nodeDict.Add(realName, dicList);
                        }
                    }
                    else if (typeof(TeaModel).IsAssignableFrom(propertyType))
                    {
                        nodeDict.Add(realName, getDictFromXml(node.Item(0), propertyType));
                    }
                    else
                    {
                        string value = node.Item(0).InnerText;
                        nodeDict.Add(realName, mapObj(propertyType, value));
                    }
                }
                else
                {
                    nodeDict.Add(realName, null);
                }
            }
            return nodeDict;
        }

        private static object mapObj(Type propertyType, string value)
        {
            if (value == null)
            {
                return null;
            }
            else if (propertyType == typeof(int?))
            {
                return Convert.ToInt32(value);
            }
            else if (propertyType == typeof(long?))
            {
                return Convert.ToInt64(value);
            }
            else if (propertyType == typeof(float?))
            {
                return Convert.ToSingle(value);
            }
            else if (propertyType == typeof(double?))
            {
                return Convert.ToDouble(value);
            }
            else if (propertyType == typeof(bool?))
            {
                return Convert.ToBoolean(value);
            }
            else if (propertyType == typeof(short?))
            {
                return Convert.ToInt16(value);
            }
            else if (propertyType == typeof(ushort?))
            {
                return Convert.ToUInt16(value);
            }
            else if (propertyType == typeof(uint?))
            {
                return Convert.ToUInt32(value);
            }
            else if (propertyType == typeof(ulong?))
            {
                return Convert.ToUInt64(value);
            }
            else
            {
                return Convert.ChangeType(value, propertyType);
            }
        }

        internal static string SerializeXml(object obj)
        {
            Type type = obj.GetType();
            if (typeof(TeaModel).IsAssignableFrom(type))
            {
                return SerializeXmlByModel((TeaModel) obj);
            }
            else if (obj is Dictionary<string, object>)
            {
                return SerializeXmlByDict((Dictionary<string, object>) obj);
            }
            else
            {
                return string.Empty;
            }
        }

        internal static string SerializeXmlByModel(TeaModel obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            if (obj == null || properties.Length == 0)
            {
                return string.Empty;
            }

            PropertyInfo propertyInfo = properties[0];
            NameInMapAttribute attribute = propertyInfo.GetCustomAttribute(typeof(NameInMapAttribute)) as NameInMapAttribute;
            string realName = attribute == null ? propertyInfo.Name : attribute.Name;
            object rootObj = propertyInfo.GetValue(obj);

            XElement element = new XElement(realName);
            GetXmlFactory(rootObj, element);

            return element.ToString();
        }

        private static string SerializeXmlByDict(Dictionary<string, object> dict)
        {
            if (dict == null || dict.Count == 0)
            {
                return string.Empty;
            }

            string nodeName = dict.Keys.ToList() [0];
            XElement element = new XElement(nodeName);
            GetXmlFactory(dict[nodeName], element);

            return element.ToString();
        }

        private static void GetXmlFactory(object obj, XElement element, XElement xParent = null)
        {
            if (obj == null)
            {
                return;
            }
            Type type = obj.GetType();

            if (typeof(IList).IsAssignableFrom(type))
            {
                if (xParent == null)
                {
                    throw new ArgumentException("unsupported nest list.");
                }
                IList list = (IList) obj;
                string nodeName = element.Name.LocalName;
                for (int j = 0; j < list.Count; j++)
                {
                    XElement xNode = new XElement(nodeName);
                    GetXmlFactory(list[j], xNode);
                    xParent.Add(xNode);
                }
                return;
            }

            if (typeof(TeaModel).IsAssignableFrom(type))
            {
                GetXml((TeaModel) obj, element);

            }
            else if (obj is Dictionary<string, object>)
            {
                GetXml((Dictionary<string, object>) obj, element);
            }
            else
            {
                element.Add(obj);
            }

            if (xParent != null)
            {
                xParent.Add(element);
            }

        }

        private static void GetXml(Dictionary<string, object> dict, XElement element)
        {
            foreach (var keypair in dict)
            {
                XElement xNode = new XElement(keypair.Key);
                GetXmlFactory(keypair.Value, xNode, element);
            }
        }

        private static void GetXml(TeaModel model, XElement element)
        {
            Type type = model.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                Type property = propertyInfo.PropertyType;
                NameInMapAttribute attribute = propertyInfo.GetCustomAttribute(typeof(NameInMapAttribute)) as NameInMapAttribute;
                string realName = attribute == null ? propertyInfo.Name : attribute.Name;
                XElement node = new XElement(realName);
                GetXmlFactory(propertyInfo.GetValue(model), node, element);
            }
        }

    }
}
