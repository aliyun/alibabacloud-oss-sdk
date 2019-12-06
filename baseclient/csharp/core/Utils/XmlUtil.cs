using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

using Tea;

[assembly : InternalsVisibleTo("UnitTests")]

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

                if (node != null && node.Count > 0)
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
            else if (propertyType == typeof(string))
            {
                return value;
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
                return Convert.ToDouble(value);
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
            XElement xRoot;
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            if (properties.Length > 0)
            {
                PropertyInfo propertyInfo = properties[0];
                NameInMapAttribute attribute = propertyInfo.GetCustomAttribute(typeof(NameInMapAttribute)) as NameInMapAttribute;
                string realName = attribute == null ? propertyInfo.Name : attribute.Name;
                object rootObj = propertyInfo.GetValue(obj);
                xRoot = GetXml(rootObj, realName);
                return xRoot.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        internal static XElement GetXml(object obj, string nodeName)
        {
            XElement element = new XElement(nodeName);
            if (obj == null)
            {
                return element;
            }
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                Type property = propertyInfo.PropertyType;
                NameInMapAttribute attribute = propertyInfo.GetCustomAttribute(typeof(NameInMapAttribute)) as NameInMapAttribute;
                string realName = attribute == null ? propertyInfo.Name : attribute.Name;
                if (typeof(IList).IsAssignableFrom(property))
                {
                    IList list = (IList) propertyInfo.GetValue(obj);
                    Type innerPropertyType = property.GetGenericArguments() [0];
                    if (list != null)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (typeof(TeaModel).IsAssignableFrom(innerPropertyType))
                            {
                                element.Add(GetXml(list[j], realName));
                            }
                            else
                            {
                                XElement itemElement = new XElement(realName);
                                itemElement.Add(list[j]);
                                element.Add(itemElement);
                            }
                        }
                    }
                    else
                    {
                        XElement nullElement = new XElement(realName);
                        element.Add(nullElement);
                    }
                }
                else if (typeof(TeaModel).IsAssignableFrom(property))
                {
                    object nodeObj = propertyInfo.GetValue(obj);
                    element.Add(GetXml(nodeObj, realName));
                }
                else
                {
                    XElement nodeElement = new XElement(realName);
                    object nodeObj = propertyInfo.GetValue(obj);
                    nodeElement.Add(nodeObj);
                    element.Add(nodeElement);
                }
            }

            return element;
        }

    }
}
