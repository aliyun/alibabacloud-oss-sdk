import Foundation
import SWXMLHash

class XMLUtil {
    func parseError(_ xmlString: String) -> [String: Any] {
        let resultDict = parseXMLToDict(xmlString)
        
        if let errorDict = resultDict["Error"] as? [String: Any] {
            let filteredDict = errorDict.filter { key, _ in
                ["Code", "Message", "RequestId", "HostId"].contains(key)
            }
            return filteredDict
        } else {
            return [:]
        }
    }

    func parseXMLToDict(_ xmlString: String) -> [String: Any] {
        let xml = XMLHash.parse(xmlString)
        return parseXMLElementToDict(element: xml) ?? [:]
    }

    func parseXMLElementToDict(element: XMLIndexer) -> [String: Any]? {
        var resultDict: [String: Any] = [:]

        for child in element.children {
            if child.children.isEmpty {
                resultDict[child.element!.name] = child.element!.text
            } else {
                if let dict = parseXMLElementToDict(element: child) {
                    resultDict[child.element!.name] = dict
                }
            }
        }
        return resultDict.isEmpty ? nil : resultDict
    }
}
