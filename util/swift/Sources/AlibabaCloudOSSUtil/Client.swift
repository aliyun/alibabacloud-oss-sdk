import Foundation
import CryptoSwift
import Tea

open class Client {
    private static var signKeyList = [
        "location",
        "cors",
        "objectMeta",
        "uploadId",
        "partNumber",
        "security-token",
        "position",
        "img",
        "style",
        "styleName",
        "replication",
        "replicationProgress",
        "replicationLocation",
        "cname",
        "qos",
        "startTime",
        "endTime",
        "symlink",
        "x-oss-process",
        "response-content-type",
        "response-content-language",
        "response-expires",
        "response-cache-control",
        "response-content-disposition",
        "response-content-encoding",
        "udf",
        "udfName",
        "udfImage",
        "udfId",
        "udfImageDesc",
        "udfApplication",
        "udfApplicationLog",
        "restore",
        "callback",
        "callback-var",
        "policy",
        "encryption",
        "versions",
        "versioning",
        "versionId"
    ]
    
    static let systemContentType: [String: String] = [
        ".323": "text/h323",
        ".asx": "video/x-ms-asf",
        ".acx": "application/internet-property-stream",
        ".ai": "application/postscript",
        ".aif": "audio/x-aiff",
        ".aiff": "audio/aiff",
        ".axs": "application/olescript",
        ".aifc": "audio/aiff",
        ".asr": "video/x-ms-asf",
        ".avi": "video/x-msvideo",
        ".asf": "video/x-ms-asf",
        ".au": "audio/basic",
        ".application": "application/x-ms-application",
        ".bin": "application/octet-stream",
        ".bas": "text/plain",
        ".bcpio": "application/x-bcpio",
        ".bmp": "image/bmp",
        ".cdf": "application/x-cdf",
        ".cat": "application/vndms-pkiseccat",
        
        ".crt": "application/x-x509-ca-cert",
        ".c": "text/plain",
        ".css": "text/css",
        ".cer": "application/x-x509-ca-cert",
        ".crl": "application/pkix-crl",
        ".cmx": "image/x-cmx",
        ".csh": "application/x-csh",
        ".cod": "image/cis-cod",
        ".cpio": "application/x-cpio",
        ".clp": "application/x-msclip",
        ".crd": "application/x-mscardfile",
        ".deploy": "application/octet-stream",
        ".dll": "application/x-msdownload",
        ".dot": "application/msword",
        ".doc": "application/msword",
        ".dvi": "application/x-dvi",
        ".dir": "application/x-director",
        ".dxr": "application/x-director",
        ".der": "application/x-x509-ca-cert",
        ".dib": "image/bmp",
        ".dcr": "application/x-director",
        ".disco": "text/xml",
        ".exe": "application/octet-stream",
        ".etx": "text/x-setext",
        ".evy": "application/envoy",
        ".eml": "message/rfc822",
        ".eps": "application/postscript",
        ".flr": "x-world/x-vrml",
        ".fif": "application/fractals",
        ".gtar": "application/x-gtar",
        ".gif": "image/gif",
        ".gz": "application/x-gzip",
        ".hta": "application/hta",
        ".htc": "text/x-component",
        ".htt": "text/webviewhtml",
        ".h": "text/plain",
        ".hdf": "application/x-hdf",
        ".hlp": "application/winhlp",
        ".html": "text/html",
        ".htm": "text/html",
        ".hqx": "application/mac-binhex40",
        ".isp": "application/x-internet-signup",
        ".iii": "application/x-iphone",
        ".ief": "image/ief",
        ".ivf": "video/x-ivf",
        ".ins": "application/x-internet-signup",
        ".ico": "image/x-icon",
        ".jpg": "image/jpeg",
        ".jfif": "image/pjpeg",
        ".jpe": "image/jpeg",
        ".jpeg": "image/jpeg",
        ".js": "application/x-javascript",
        ".lsx": "video/x-la-asf",
        ".latex": "application/x-latex",
        ".lsf": "video/x-la-asf",
        ".manifest": "application/x-ms-manifest",
        ".mhtml": "message/rfc822",
        ".mny": "application/x-msmoney",
        ".mht": "message/rfc822",
        ".mid": "audio/mid",
        ".mpv2": "video/mpeg",
        ".man": "application/x-troff-man",
        ".mvb": "application/x-msmediaview",
        ".mpeg": "video/mpeg",
        ".m3u": "audio/x-mpegurl",
        ".mdb": "application/x-msaccess",
        ".mpp": "application/vnd.ms-project",
        ".m1v": "video/mpeg",
        ".mpa": "video/mpeg",
        ".me": "application/x-troff-me",
        ".m13": "application/x-msmediaview",
        ".movie": "video/x-sgi-movie",
        ".m14": "application/x-msmediaview",
        ".mpe": "video/mpeg",
        ".mp2": "video/mpeg",
        ".mov": "video/quicktime",
        ".mp3": "audio/mpeg",
        ".mpg": "video/mpeg",
        ".ms": "application/x-troff-ms",
        ".nc": "application/x-netcdf",
        ".nws": "message/rfc822",
        ".oda": "application/oda",
        ".ods": "application/oleobject",
        ".pmc": "application/x-perfmon",
        ".p7r": "application/x-pkcs7-certreqresp",
        ".p7b": "application/x-pkcs7-certificates",
        ".p7s": "application/pkcs7-signature",
        ".pmw": "application/x-perfmon",
        ".ps": "application/postscript",
        ".p7c": "application/pkcs7-mime",
        ".pbm": "image/x-portable-bitmap",
        ".ppm": "image/x-portable-pixmap",
        ".pub": "application/x-mspublisher",
        ".pnm": "image/x-portable-anymap",
        ".png": "image/png",
        ".pml": "application/x-perfmon",
        ".p10": "application/pkcs10",
        ".pfx": "application/x-pkcs12",
        ".p12": "application/x-pkcs12",
        ".pdf": "application/pdf",
        ".pps": "application/vnd.ms-powerpoint",
        ".p7m": "application/pkcs7-mime",
        ".pko": "application/vndms-pkipko",
        ".ppt": "application/vnd.ms-powerpoint",
        ".pmr": "application/x-perfmon",
        ".pma": "application/x-perfmon",
        ".pot": "application/vnd.ms-powerpoint",
        ".prf": "application/pics-rules",
        ".pgm": "image/x-portable-graymap",
        ".qt": "video/quicktime",
        ".ra": "audio/x-pn-realaudio",
        ".rgb": "image/x-rgb",
        ".ram": "audio/x-pn-realaudio",
        ".rmi": "audio/mid",
        ".ras": "image/x-cmu-raster",
        ".roff": "application/x-troff",
        ".rtf": "application/rtf",
        ".rtx": "text/richtext",
        ".sv4crc": "application/x-sv4crc",
        ".spc": "application/x-pkcs7-certificates",
        ".setreg": "application/set-registration-initiation",
        ".snd": "audio/basic",
        ".stl": "application/vndms-pkistl",
        ".setpay": "application/set-payment-initiation",
        ".stm": "text/html",
        ".shar": "application/x-shar",
        ".sh": "application/x-sh",
        ".sit": "application/x-stuffit",
        ".spl": "application/futuresplash",
        ".sct": "text/scriptlet",
        ".scd": "application/x-msschedule",
        ".sst": "application/vndms-pkicertstore",
        ".src": "application/x-wais-source",
        ".sv4cpio": "application/x-sv4cpio",
        ".tex": "application/x-tex",
        ".tgz": "application/x-compressed",
        ".t": "application/x-troff",
        ".tar": "application/x-tar",
        ".tr": "application/x-troff",
        ".tif": "image/tiff",
        ".txt": "text/plain",
        ".texinfo": "application/x-texinfo",
        ".trm": "application/x-msterminal",
        ".tiff": "image/tiff",
        ".tcl": "application/x-tcl",
        ".texi": "application/x-texinfo",
        ".tsv": "text/tab-separated-values",
        ".ustar": "application/x-ustar",
        ".uls": "text/iuls",
        ".vcf": "text/x-vcard",
        ".wps": "application/vnd.ms-works",
        ".wav": "audio/wav",
        ".wrz": "x-world/x-vrml",
        ".wri": "application/x-mswrite",
        ".wks": "application/vnd.ms-works",
        ".wmf": "application/x-msmetafile",
        ".wcm": "application/vnd.ms-works",
        ".wrl": "x-world/x-vrml",
        ".wdb": "application/vnd.ms-works",
        ".wsdl": "text/xml",
        ".xap": "application/x-silverlight-app",
        ".xml": "text/xml",
        ".xlm": "application/vnd.ms-excel",
        ".xaf": "x-world/x-vrml",
        ".xla": "application/vnd.ms-excel",
        ".xls": "application/vnd.ms-excel",
        ".xof": "x-world/x-vrml",
        ".xlt": "application/vnd.ms-excel",
        ".xlc": "application/vnd.ms-excel",
        ".xsl": "text/xml",
        ".xbm": "image/x-xbitmap",
        ".xlw": "application/vnd.ms-excel",
        ".xpm": "image/x-xpixmap",
        ".xwd": "image/x-xwindowdump",
        ".xsd": "text/xml",
        ".z": "application/x-compress",
        ".zip": "application/x-zip-compressed",
        ".*": "application/octet-stream"
    ]
    
    static let contentType: [String: String] = [
        ".xlsx": "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
        ".xltx": "application/vnd.openxmlformats-officedocument.spreadsheetml.template",
        ".potx": "application/vnd.openxmlformats-officedocument.presentationml.template",
        ".ppsx": "application/vnd.openxmlformats-officedocument.presentationml.slideshow",
        ".pptx": "application/vnd.openxmlformats-officedocument.presentationml.presentation",
        ".sldx": "application/vnd.openxmlformats-officedocument.presentationml.slide",
        ".docx": "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
        ".dotx": "application/vnd.openxmlformats-officedocument.wordprocessingml.template",
        ".xlam": "application/vnd.ms-excel.addin.macroEnabled.12",
        ".xlsb": "application/vnd.ms-excel.sheet.binary.macroEnabled.12",
        ".apk": "application/vnd.android.package-archive",
        ".cpt": "application/mac-compactpro",
        ".ogg": "application/ogg",
        ".mif": "application/vnd.mif",
        ".odc": "application/vnd.oasis.opendocument.chart",
        ".odb": "application/vnd.oasis.opendocument.database",
        ".odf": "application/vnd.oasis.opendocument.formula",
        ".odg": "application/vnd.oasis.opendocument.graphics",
        ".otg": "application/vnd.oasis.opendocument.graphics-template",
        ".odi": "application/vnd.oasis.opendocument.image",
        ".odp": "application/vnd.oasis.opendocument.presentation",
        ".otp": "application/vnd.oasis.opendocument.presentation-template",
        ".ots": "application/vnd.oasis.opendocument.spreadsheet-template",
        ".odt": "application/vnd.oasis.opendocument.text",
        ".odm": "application/vnd.oasis.opendocument.text-master",
        ".ott": "application/vnd.oasis.opendocument.text-template",
        ".oth": "application/vnd.oasis.opendocument.text-web",
        ".sxw": "application/vnd.sun.xml.writer",
        ".stw": "application/vnd.sun.xml.writer.template",
        ".sxc": "application/vnd.sun.xml.calc",
        ".stc": "application/vnd.sun.xml.calc.template",
        ".sxd": "application/vnd.sun.xml.draw",
        ".std": "application/vnd.sun.xml.draw.template",
        ".sxi": "application/vnd.sun.xml.impress",
        ".sti": "application/vnd.sun.xml.impress.template",
        ".sxg": "application/vnd.sun.xml.writer.global",
        ".sxm": "application/vnd.sun.xml.math",
        ".sis": "application/vnd.symbian.install",
        ".wbxml": "application/vnd.wap.wbxml",
        ".wmlc": "application/vnd.wap.wmlc",
        ".wmlsc": "application/vnd.wap.wmlscriptc",
        ".torrent": "application/x-bittorrent",
        ".bz2": "application/x-bzip2",
        ".vcd": "application/x-cdlink",
        ".pgn": "application/x-chess-pgn",
        ".jar": "application/x-java-archive",
        ".jnlp": "application/x-java-jnlp-file",
        ".ksp": "application/x-kspread",
        ".chrt": "application/x-kchart",
        ".kil": "application/x-killustrator",
        ".rpm": "application/x-rpm",
        ".swf": "application/x-shockwave-flash",
        ".ms": "application/x-troff-ms",
        ".wma": "audio/x-ms-wma",
        ".wax": "audio/x-ms-wax",
        ".pdb": "chemical/x-pdb",
        ".xyz": "chemical/x-xyz",
        ".wbmp": "image/vnd.wap.wbmp",
        ".ras": "image/x-cmu-raster",
        ".pnm": "image/x-portable-anymap",
        ".pbm": "image/x-portable-bitmap",
        ".pgm": "image/x-portable-graymap",
        ".ppm": "image/x-portable-pixmap",
        ".rgb": "image/x-rgb",
        ".xbm": "image/x-xbitmap",
        ".xpm": "image/x-xpixmap",
        ".xwd": "image/x-xwindowdump",
        ".css": "text/css",
        ".rtx": "text/richtext",
        ".tsv": "text/tab-separated-values",
        ".jad": "text/vnd.sun.j2me.app-descriptor",
        ".wml": "text/vnd.wap.wml",
        ".wmls": "text/vnd.wap.wmlscript",
        ".etx": "text/x-setext",
        ".mxu": "video/vnd.mpegurl",
        ".flv": "video/x-flv",
        ".wm": "video/x-ms-wm",
        ".wmv": "video/x-ms-wmv",
        ".wmx": "video/x-ms-wmx",
        ".wvx": "video/x-ms-wvx",
        ".avi": "video/x-msvideo",
        ".movie": "video/x-sgi-movie",
        ".ice": "x-conference/x-cooltalk",
        ".3gp": "video/3gpp",
        ".ai": "application/postscript",
        ".aif": "audio/x-aiff",
        ".aifc": "audio/x-aiff",
        ".aiff": "audio/x-aiff",
        ".asc": "text/plain",
        ".atom": "application/atom+xml",
        ".au": "audio/basic",
        ".bin": "application/octet-stream",
        ".cdf": "application/x-netcdf",
        ".cgm": "image/cgm",
        ".class": "application/octet-stream",
        ".dcr": "application/x-director",
        ".dif": "video/x-dv",
        ".dir": "application/x-director",
        ".djv": "image/vnd.djvu",
        ".djvu": "image/vnd.djvu",
        ".dll": "application/octet-stream",
        ".dmg": "application/octet-stream",
        ".dms": "application/octet-stream",
        ".dtd": "application/xml-dtd",
        ".dv": "video/x-dv",
        ".dxr": "application/x-director",
        ".eps": "application/postscript",
        ".exe": "application/octet-stream",
        ".ez": "application/andrew-inset",
        ".gram": "application/srgs",
        ".grxml": "application/srgs+xml",
        ".gz": "application/x-gzip",
        ".htm": "text/html",
        ".html": "text/html",
        ".ico": "image/x-icon",
        ".ics": "text/calendar",
        ".ifb": "text/calendar",
        ".iges": "model/iges",
        ".igs": "model/iges",
        ".jp2": "image/jp2",
        ".jpe": "image/jpeg",
        ".jpeg": "image/jpeg",
        ".jpg": "image/jpeg",
        ".kar": "audio/midi",
        ".lha": "application/octet-stream",
        ".lzh": "application/octet-stream",
        ".m4a": "audio/mp4a-latm",
        ".m4p": "audio/mp4a-latm",
        ".m4u": "video/vnd.mpegurl",
        ".m4v": "video/x-m4v",
        ".mac": "image/x-macpaint",
        ".mathml": "application/mathml+xml",
        ".mesh": "model/mesh",
        ".mid": "audio/midi",
        ".midi": "audio/midi",
        ".mp4": "video/mp4",
        ".mpeg": "video/mpeg",
        ".mpg": "video/mpeg",
        ".mpga": "audio/mpeg",
        ".msh": "model/mesh",
        ".nc": "application/x-netcdf",
        ".oda": "application/oda",
        ".ogv": "video/ogv",
        ".pct": "image/pict",
        ".pic": "image/pict",
        ".pict": "image/pict",
        ".pnt": "image/x-macpaint",
        ".pntg": "image/x-macpaint",
        ".ps": "application/postscript",
        ".qt": "video/quicktime",
        ".qti": "image/x-quicktime",
        ".qtif": "image/x-quicktime",
        ".ram": "audio/x-pn-realaudio",
        ".rdf": "application/rdf+xml",
        ".rm": "application/vnd.rn-realmedia",
        ".roff": "application/x-troff",
        ".sgm": "text/sgml",
        ".sgml": "text/sgml",
        ".silo": "model/mesh",
        ".skd": "application/x-koan",
        ".skm": "application/x-koan",
        ".skp": "application/x-koan",
        ".skt": "application/x-koan",
        ".smi": "application/smil",
        ".smil": "application/smil",
        ".snd": "audio/basic",
        ".so": "application/octet-stream",
        ".svg": "image/svg+xml",
        ".t": "application/x-troff",
        ".texi": "application/x-texinfo",
        ".texinfo": "application/x-texinfo",
        ".tif": "image/tiff",
        ".tiff": "image/tiff",
        ".tr": "application/x-troff",
        ".txt": "text/plain",
        ".vrml": "model/vrml",
        ".vxml": "application/voicexml+xml",
        ".webm": "video/webm",
        ".wrl": "model/vrml",
        ".xht": "application/xhtml+xml",
        ".xhtml": "application/xhtml+xml",
        ".xml": "application/xml",
        ".xsl": "application/xml",
        ".xslt": "application/xslt+xml",
        ".xul": "application/vnd.mozilla.xul+xml",
        ".webp": "image/webp"
    ]
    
    public static func getErrMessage(_ msg: String?) -> [String: Any] {
        guard let msg = msg, !msg.isEmpty else {
                return [:]
        }
        let parser = XMLUtil()
        let result = parser.parseError(msg)
        return result
    }
    
    public static func toMeta(_ val: [String: String]?, _ prefix_: String?) -> [String: String] {
        var result: [String: String] = [:]
        guard let val = val else {
            return result
        }
        let prefix = prefix_ ?? ""
        for (key, value) in val {
            if key.contains(prefix) {
                result[key] = String(describing: value)
            } else {
                result["\(prefix)\(key)"] = String(describing: value)
            }
        }
        return result
    }

    public static func parseMeta(_ val: [String: String]?, _ prefix_: String?) -> [String: String] {
        var result: [String: String] = [:]
        guard let val = val else {
            return result
        }
        let prefix = prefix_ ?? ""
        for (key, value) in val {
            if key.hasPrefix(prefix) {
                if let range = key.range(of: prefix) {
                    let newKey = key.replacingCharacters(in: range, with: "")
                    result[newKey] = String(describing: value)
                }
                result[key.replacingOccurrences(of: prefix, with: "")] = String(describing: value)
            } else {
                result[key] = String(describing: value)
            }
        }
        return result;
    }

    public static func getContentType(_ fileName: String?) -> String {
        let fileName_ = fileName ?? ""
        let index = fileName_.lastIndex(of: ".")
        guard let index = index else {
            return "text/plain"
        }
        let suffix = String(fileName_[index...])
        let type = systemContentType[suffix]
        return type ?? contentType[suffix] ?? "text/plain"
    }

    public static func getContentMD5(_ body: String?, _ isEnableMD5: Bool?) -> String {
        let isEnableMD5_ = isEnableMD5 ?? false
        let body_ = body ?? ""
        guard isEnableMD5_ else {
            return ""
        }
        if let bodyData = body_.data(using: .utf8) {
            let md5 = bodyData.md5()
            return Data(md5).base64EncodedString()
        }
        return ""
    }

    public static func encode(_ val: String?, _ encodeType: String?) -> String {
        guard let val = val else {
            return ""
        }
        
        guard let encodeType = encodeType else {
            return val
        }
        
        var strs = val.split(separator: "/").map(String.init)
        var str = strs.last ?? ""
        
        switch encodeType {
        case "Base64":
            if let data = str.data(using: .utf8) {
                str = data.base64EncodedString()
                strs[strs.count - 1] = str
            }
        case "UrlEncode":
            if let encodedStr = str.addingPercentEncoding(withAllowedCharacters: .urlHostAllowed) {
                strs[strs.count - 1] = encodedStr
            }
        default:
            break
        }
        return strs.joined(separator: "/")
    }

    public static func getHost(_ bucketName: String?, _ regionId: String?, _ endpoint: String?, _ hostModel: String?) -> String {
        var r = regionId
        var e = endpoint
        
        if r?.isEmpty ?? true {
            r = "cn-hangzhou"
        }
        
        if e?.isEmpty ?? true {
            e = "oss-\(r!).aliyuncs.com"
        }
        
        guard let b = bucketName, !b.isEmpty else {
            return e!
        }
        
        let host: String
        if hostModel == "ip" {
            host = "\(e!)/\(b)"
        } else if hostModel == "cname" {
            host = e!
        } else {
            host = "\(b).\(e!)"
        }
        
        return host
    }

    public static func inject(_ body: InputStream?, _ res: inout [String: String]?) -> VerifyStream {
        var map = res ?? [:]
        let verifyStream = VerifyStream(inputStream: body ?? InputStream(data: Data()), map: &map)
        verifyStream.open()
        res = map
        return verifyStream
    }

    public static func getSignature(_ request: Tea.TeaRequest?, _ bucketName: String?, _ accessKeyId: String?, _ accessKeySecret: String?, _ signatureVersion: String?, _ addtionalHeaders: [String]?) -> String {
        return ""
    }

    public static func decode(_ val: String?, _ decodeType: String?) -> String {
        guard let val = val else {
            return ""
        }
        
        guard let decodeType = decodeType else {
            return val
        }
        
        var strs = val.split(separator: "/").map(String.init)
        guard !strs.isEmpty else {
            return val
        }
        print(strs)
        print(strs.last ?? "")
        switch decodeType {
        case "Base64Decode":
            if let data = Data(base64Encoded: strs.last ?? ""),
               let decodedString = String(data: data, encoding: .utf8) {
                strs[strs.count - 1] = decodedString
            }
        case "UrlDecode":
            if let decodedString = strs.last?.removingPercentEncoding {
                strs[strs.count - 1] = decodedString
            }
        default:
            break
        }
        return strs.joined(separator: "/")
    }
}
