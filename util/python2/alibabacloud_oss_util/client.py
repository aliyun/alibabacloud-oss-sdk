# -*- coding: utf-8 -*-
import hashlib
import hmac
import base64

from xml.etree import ElementTree
try:
    from urllib import quote, unquote
except ImportError:
    from urllib.parse import quote, unquote

from alibabacloud_oss_util import verify_stream


class Client(object):
    SIGN_KEY_LIST = (
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
    )
    SYSTEM_CONTENT_TYPE = {
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
    }
    CONTENT_TYPE = {
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
    }
    _FIELDS_MAP = {
        'Code': 'code',
        'Message': 'message',
        'RequestId': 'request_id',
        'HostId': 'host_id'
    }

    @staticmethod
    def get_err_message(msg):
        """
        Parse msg into a object
        @return the object
        """
        err_fields = ('Code', 'Message', 'RequestId', 'HostId')
        err_resp = {}
        et = ElementTree.fromstring(msg)
        if et.tag == 'Error':
            for lf in et:
                if lf.tag in err_fields:
                    err_resp[lf.tag] = lf.text
        return err_resp

    @staticmethod
    def to_meta(val, prefix):
        """
        Add prefix string as prefix for keys of val
        @rtype: dict
        @return the final map[string]string
        """
        result = {}
        if isinstance(val, dict):
            for key, value in val.items():
                if prefix in key:
                    result[key] = value
                else:
                    result[prefix + key] = value
        return result

    @staticmethod
    def parse_meta(val, prefix):
        """
        Remove prefix string from keys of val
        @rtype: dict
        @return the final map[string]string
        """
        result = {}
        if isinstance(val, dict):
            for key, value in val.items():
                if key.startswith(prefix):
                    k = key.replace(prefix, '')
                    result[k] = value
                else:
                    result[key] = value
        return result

    @staticmethod
    def get_content_type(file_name):
        """
        Get content type according to the fileName
        @return the content type
        """
        suffix = '.' + file_name.split('.')[-1]
        type = Client.SYSTEM_CONTENT_TYPE.get(suffix)
        return Client.CONTENT_TYPE[suffix] if type is None else type

    @staticmethod
    def get_content_md5(body, is_enable_dm5=True):
        """
        If isEnableMD5 is true, calculate md5 according to body, or return ''
        @return the md5
        """
        if is_enable_dm5 is True:
            if isinstance(body, str):
                body = body.encode('utf-8')
            md5 = hashlib.md5(body).digest()
            return base64.b64encode(md5).decode('utf-8')
        else:
            return ''

    @staticmethod
    def get_host(bucket_name, region_id="cn-hangzhou", endpoint=None, host_model=None):
        """
        Get endpoint according to bucketName, regionId, endpoint and hostModel
        @return the endpoint string
        """
        if not region_id:
            region_id = "cn-hangzhou"
        if not endpoint:
            endpoint = 'oss-%s.aliyuncs.com' % region_id
        if bucket_name:
            if 'ip' == host_model:
                host = '%s/%s' % (endpoint, bucket_name)
            elif 'cname' == host_model:
                host = endpoint
            else:
                host = bucket_name + '.' + endpoint
        else:
            host = endpoint
        return host

    @staticmethod
    def decode(val, decode_type):
        """
        Decode val according to decodeType
        @param decode_type the type must be Base64 or UrlEncode
        @return the decoded string
        """
        if decode_type == 'Base64Decode':
            return base64.b64decode(val.encode('utf-8')).decode('utf-8')
        elif decode_type == 'UrlDecode':
            return unquote(val)
        return val

    @staticmethod
    def encode(val, encode_type):
        """
        Encode val according to encodeType
        @param encode_type the type must be Base64 or UrlEncode
        @return the encoded string
        """
        if encode_type is None:
            return val

        strs = val.split('/')
        if encode_type == 'Base64':
            strs[-1] = base64.b64encode(strs[-1].encode('utf-8')).decode('utf-8')
        elif encode_type == 'UrlEncode':
            strs[-1] = quote(strs[-1], safe='')

        return '/'.join(strs)

    @staticmethod
    def inject(body, res):
        """
        Package body as a new readable, and res record the md5 and crc of the readable.
        @return the new readable
        """
        return verify_stream.VerifyStream(body, res)

    @staticmethod
    def get_signature(request,
                      bucket_name,
                      access_key_id,
                      access_key_secret,
                      signature_version='V1',
                      addtional_headers=None):
        """
        If signatureVersion is V1, get signature according to request, bucketName, accessKeyId and accessKeySecret.
        If signatureVersion is V2, get signature according to request, bucketName, accessKeyId, accessKeySecret and
        addtionalHeaders.
        @return the signature string
        """
        if signature_version and signature_version.upper() == 'V2':
            if addtional_headers:
                signature_v2 = Client._signature_v2(request, bucket_name, access_key_secret, addtional_headers)
                signature = 'OSS2 AccessKeyId:%s,AdditionalHeaders:%s,Signature:%s' % \
                            (access_key_id, ';'.join(addtional_headers), signature_v2)
            else:
                signature_v2 = Client._signature_v2(request, bucket_name, access_key_secret, addtional_headers)
                signature = 'OSS2 AccessKeyId:%s,Signature:%s' % (access_key_id, signature_v2)
        else:
            resource = ''
            if bucket_name:
                resource = '/%s' % bucket_name
            resource += request.pathname
            if request.query and '?' not in resource:
                resource += '?'

            sorted_query_keys = sorted(list(request.query))
            for k in sorted_query_keys:
                if k in Client.SIGN_KEY_LIST and request.query.get(k):
                    if resource.endswith('?'):
                        resource += '%s=%s' % (k, request.query.get(k))
                    else:
                        resource += '&%s=%s' % (k, request.query.get(k))
            signature = 'OSS %s:%s' % (access_key_id, Client._signature_v1(request, resource, access_key_secret))
        return signature

    @staticmethod
    def _signature_v1(req, resource, secret):
        tmp = {}
        for k, v in req.headers.items():
            if k.lower().startswith('x-oss-'):
                if v is not None:
                    tmp[k.lower()] = v
        sorted_keys = list(tmp)
        sorted_keys.sort()
        string = ''
        for sk in sorted_keys:
            string += '%s:%s\n' % (sk, tmp.get(sk))

        date = req.headers.get('date', '')
        content_type = req.headers.get('content-type', '')
        content_md5 = req.headers.get('content-md5', '')

        date = date if date is not None else ''
        content_type = content_type if content_type is not None else ''
        content_md5 = content_md5 if content_md5 is not None else ''

        sign_str = '%s\n%s\n%s\n%s\n%s%s' % (req.method, content_md5, content_type, date, string, resource)
        secret = secret.encode('utf-8')
        sign_str = sign_str.encode('utf-8')
        hash_val = hmac.new(secret, sign_str, hashlib.sha1).digest()
        signature = base64.b64encode(hash_val).strip().decode('utf-8')
        return signature

    @staticmethod
    def _signature_v2(req, bucket_name, access_key_secret, additional_headers):
        resource = ''
        pathname = '/%s%s' % (bucket_name, req.pathname) if bucket_name else req.pathname

        sorted_keys = []
        if req.query is not None:
            sorted_keys = list(req.query)

        strs = pathname.split('?')
        resource += quote(strs[0], safe='')

        if '?' in pathname:
            sorted_keys.append(strs[1])

        sorted_keys.sort()
        if len(sorted_keys) > 0:
            resource += '?'

        for key in sorted_keys:
            if req.query.get(key):
                if resource.endswith('?'):
                    resource += '%s=%s' % (quote(key, safe=''), quote(req.query.get(key), safe=''))
                else:
                    resource += '&%s=%s' % (quote(key, safe=''), quote(req.query.get(key), safe=''))
            else:
                if resource.endswith('?'):
                    resource += quote(key, safe='')
                else:
                    resource += '&%s' % quote(key, safe='')

        # get sign str
        tmp = {}
        if additional_headers is None:
            headers = []
            additional_headers = []
        else:
            headers = list(additional_headers)
        for k, v in req.headers.items():
            if v is not None:
                if k in headers or k.lower().startswith('x-oss-'):
                    tmp[k.lower()] = v

        sorted_keys = list(tmp)
        sorted_keys.sort()
        can_oss_headers = ''
        for key in sorted_keys:
            can_oss_headers += '%s:%s\n' % (key, tmp.get(key))

        date = req.headers.get('date', '')
        content_type = req.headers.get('content-type', '')
        content_md5 = req.headers.get('content-md5', '')

        date = date if date is not None else ''
        content_type = content_type if content_type is not None else ''
        content_md5 = content_md5 if content_md5 is not None else ''

        sign_str = '%s\n%s\n%s\n%s\n%s%s\n%s' % (
            req.method, content_md5, content_type, date, can_oss_headers, ';'.join(additional_headers), resource)

        secret = access_key_secret.encode('utf-8')
        sign_str = sign_str.encode('utf-8')
        hash_val = hmac.new(secret, sign_str, hashlib.sha256).digest()
        signature = base64.b64encode(hash_val).decode('utf-8')
        return signature
