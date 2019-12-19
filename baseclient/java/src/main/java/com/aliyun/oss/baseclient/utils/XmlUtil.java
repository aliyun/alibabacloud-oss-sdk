package com.aliyun.oss.baseclient.utils;

import com.aliyun.tea.NameInMap;
import com.aliyun.tea.TeaException;
import com.aliyun.tea.TeaModel;
import com.aliyun.tea.utils.StringUtils;
import com.google.gson.Gson;
import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.DocumentHelper;
import org.dom4j.Element;

import java.lang.reflect.Array;
import java.lang.reflect.Field;
import java.lang.reflect.InvocationTargetException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Set;

public class XmlUtil {
    public static Map<String, Object> DeserializeXml(String xmlStr, Class type) throws InstantiationException, IllegalAccessException, NoSuchMethodException, InvocationTargetException {
        Map<String, Object> result = new HashMap<>();
        if (StringUtils.isEmpty(xmlStr)) {
            return result;
        }
        Document contentXmlDoc;
        try {
            contentXmlDoc = DocumentHelper.parseText(xmlStr);
        } catch (DocumentException e) {
            result = new Gson().fromJson(xmlStr, Map.class);
            return result;
        }
        Element rootElement = contentXmlDoc.getRootElement();
        Field[] properties = type.getFields();
        Field resultField = null;
        for (Field field : properties) {
            field.setAccessible(true);
            NameInMap nameAnnotation = field.getAnnotation(NameInMap.class);
            String realName = nameAnnotation == null ? field.getName() : nameAnnotation.value();
            if (realName.equals(rootElement.getName())) {
                resultField = field;
                break;
            }
        }
        if (null != resultField) {
            if (String.class == resultField.getType()) {
                result.put(rootElement.getName(), rootElement.getText());
                return result;
            }
            result.put(rootElement.getName(), getValueFromXml(rootElement, resultField.getType()));
        }
        return result;
    }

    private static Map<String, Object> getValueFromXml(Element element, Class type) throws IllegalAccessException, InstantiationException, NoSuchMethodException, InvocationTargetException {
        Map<String, Object> nodeDict = new HashMap<>();
        Field[] subFields = type.getFields();
        for (Field subField : subFields) {
            NameInMap nameAnnotation = subField.getAnnotation(NameInMap.class);
            String realName = nameAnnotation == null ? subField.getName() : nameAnnotation.value();
            if (subField.getType().isArray()) {
                List<Element> subElements = element.elements(realName);
                Object[] target = (Object[]) Array.newInstance(subField.getType().getComponentType(), subElements.size());
                for (int i = 0; i < subElements.size(); i++) {
                    Array.set(target, i, TeaModel.toModel(getValueFromXml(subElements.get(i), subField.getType().getComponentType()),
                            (TeaModel) subField.getType().getComponentType().newInstance()));
                }
                nodeDict.put(realName, target);
            } else if (TeaModel.class.isAssignableFrom(subField.getType())) {
                Element selfElement = element.element(realName);
                if (selfElement != null) {
                    nodeDict.put(realName, getValueFromXml(selfElement, subField.getType()));
                }
            } else {
                Element selfElement = element.element(realName);
                if (selfElement != null) {
                    nodeDict.put(realName, castType(subField.getType(), selfElement.getText()));
                }
            }
        }

        return nodeDict;
    }

    private static Object castType(Class clazz, String value) {
        if (boolean.class == clazz || Boolean.class == clazz) {
            return Boolean.parseBoolean(value);
        }
        if (int.class == clazz || Integer.class == clazz) {
            return Integer.parseInt(value);
        }
        if (long.class == clazz || Long.class == clazz) {
            return Long.parseLong(value);
        }
        return value;
    }

    public static String mapToXml(Map<String, Object> map) throws IllegalAccessException {
        if (null == map || map.isEmpty()) {
            return "";
        }
        if (map.size() != 1) {
            throw new RuntimeException("This map does not have a unique root tag");
        }
        String rootName = map.keySet().toArray(new String[]{})[0];
        Document document = DocumentHelper.createDocument();
        Element root = document.addElement(rootName);
        setValue(root, rootName, map.get(rootName));
        return document.asXML();
    }

    private static void setValue(Element element, String key, Object value) throws IllegalAccessException {
        Class clazz = value.getClass();
        if (Map.class.isAssignableFrom(clazz)) {
            Map<String, Object> map = (Map<String, Object>) value;
            for (Map.Entry<String, Object> entry: map.entrySet()) {
                if (entry.getValue() == null) {
                    continue;
                }
                if (List.class.isAssignableFrom(entry.getValue().getClass())) {
                    setValue(element, entry.getKey(), entry.getValue());
                    continue;
                }
                Element subElement = element.addElement(entry.getKey());
                setValue(subElement, entry.getKey(), entry.getValue());
            }
        } else if (List.class.isAssignableFrom(clazz)) {
            List<Object> list = (List) value;
            for (Object sub: list) {
                if (sub == null) {
                    continue;
                }
                Element subElement = element.addElement(key);
                setValue(subElement, key, sub);
            }
        }else if (TeaModel.class.isAssignableFrom(clazz)) {
            Map<String, Object> map = ((TeaModel) value).toMap();
            for (Map.Entry<String, Object> entry: map.entrySet()) {
                if (entry.getValue() == null) {
                    continue;
                }
                if (List.class.isAssignableFrom(entry.getValue().getClass())) {
                    setValue(element, entry.getKey(), entry.getValue());
                    continue;
                }
                Element subElement = element.addElement(entry.getKey());
                setValue(subElement, entry.getKey(), entry.getValue());
            }
        } else {
            element.setText(String.valueOf(value));
        }
    }
}
