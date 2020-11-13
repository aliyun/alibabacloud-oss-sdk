// This file is auto-generated, don't edit it. Thanks.

#include <alibabacloud/ossutil.hpp>
#include <boost/any.hpp>
#include <boost/algorithm/string.hpp>
#include <boost/crc.hpp>
#include <darabonba/core.hpp>
#include <iostream>
#include <map>
#include <vector>
#include <regex>
#include "crypt/md5.h"
#include "crypt/base64.h"
#include "crypt/sha1.h"
#include "crypt/sha256.h"
#include "crypt/hmac.h"
#include "tinyxml2/tinyxml2.h"

using namespace std;

vector<string> SIGN_KEY_LIST = {
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
};
map<string, string> SYSTEM_CONTENT_TYPE = {
    {".323", "text/h323"},
    {".asx", "video/x-ms-asf"},
    {".acx", "application/internet-property-stream"},
    {".ai", "application/postscript"},
    {".aif", "audio/x-aiff"},
    {".aiff", "audio/aiff"},
    {".axs", "application/olescript"},
    {".aifc", "audio/aiff"},
    {".asr", "video/x-ms-asf"},
    {".avi", "video/x-msvideo"},
    {".asf", "video/x-ms-asf"},
    {".au", "audio/basic"},
    {".application", "application/x-ms-application"},
    {".bin", "application/octet-stream"},
    {".bas", "text/plain"},
    {".bcpio", "application/x-bcpio"},
    {".bmp", "image/bmp"},
    {".cdf", "application/x-cdf"},
    {".cat", "application/vndms-pkiseccat"},
    {".crt", "application/x-x509-ca-cert"},
    {".c", "text/plain"},
    {".css", "text/css"},
    {".cer", "application/x-x509-ca-cert"},
    {".crl", "application/pkix-crl"},
    {".cmx", "image/x-cmx"},
    {".csh", "application/x-csh"},
    {".cod", "image/cis-cod"},
    {".cpio", "application/x-cpio"},
    {".clp", "application/x-msclip"},
    {".crd", "application/x-mscardfile"},
    {".deploy", "application/octet-stream"},
    {".dll", "application/x-msdownload"},
    {".dot", "application/msword"},
    {".doc", "application/msword"},
    {".dvi", "application/x-dvi"},
    {".dir", "application/x-director"},
    {".dxr", "application/x-director"},
    {".der", "application/x-x509-ca-cert"},
    {".dib", "image/bmp"},
    {".dcr", "application/x-director"},
    {".disco", "text/xml"},
    {".exe", "application/octet-stream"},
    {".etx", "text/x-setext"},
    {".evy", "application/envoy"},
    {".eml", "message/rfc822"},
    {".eps", "application/postscript"},
    {".flr", "x-world/x-vrml"},
    {".fif", "application/fractals"},
    {".gtar", "application/x-gtar"},
    {".gif", "image/gif"},
    {".gz", "application/x-gzip"},
    {".hta", "application/hta"},
    {".htc", "text/x-component"},
    {".htt", "text/webviewhtml"},
    {".h", "text/plain"},
    {".hdf", "application/x-hdf"},
    {".hlp", "application/winhlp"},
    {".html", "text/html"},
    {".htm", "text/html"},
    {".hqx", "application/mac-binhex40"},
    {".isp", "application/x-internet-signup"},
    {".iii", "application/x-iphone"},
    {".ief", "image/ief"},
    {".ivf", "video/x-ivf"},
    {".ins", "application/x-internet-signup"},
    {".ico", "image/x-icon"},
    {".jpg", "image/jpeg"},
    {".jfif", "image/pjpeg"},
    {".jpe", "image/jpeg"},
    {".jpeg", "image/jpeg"},
    {".js", "application/x-javascript"},
    {".lsx", "video/x-la-asf"},
    {".latex", "application/x-latex"},
    {".lsf", "video/x-la-asf"},
    {".manifest", "application/x-ms-manifest"},
    {".mhtml", "message/rfc822"},
    {".mny", "application/x-msmoney"},
    {".mht", "message/rfc822"},
    {".mid", "audio/mid"},
    {".mpv2", "video/mpeg"},
    {".man", "application/x-troff-man"},
    {".mvb", "application/x-msmediaview"},
    {".mpeg", "video/mpeg"},
    {".m3u", "audio/x-mpegurl"},
    {".mdb", "application/x-msaccess"},
    {".mpp", "application/vnd.ms-project"},
    {".m1v", "video/mpeg"},
    {".mpa", "video/mpeg"},
    {".me", "application/x-troff-me"},
    {".m13", "application/x-msmediaview"},
    {".movie", "video/x-sgi-movie"},
    {".m14", "application/x-msmediaview"},
    {".mpe", "video/mpeg"},
    {".mp2", "video/mpeg"},
    {".mov", "video/quicktime"},
    {".mp3", "audio/mpeg"},
    {".mpg", "video/mpeg"},
    {".ms", "application/x-troff-ms"},
    {".nc", "application/x-netcdf"},
    {".nws", "message/rfc822"},
    {".oda", "application/oda"},
    {".ods", "application/oleobject"},
    {".pmc", "application/x-perfmon"},
    {".p7r", "application/x-pkcs7-certreqresp"},
    {".p7b", "application/x-pkcs7-certificates"},
    {".p7s", "application/pkcs7-signature"},
    {".pmw", "application/x-perfmon"},
    {".ps", "application/postscript"},
    {".p7c", "application/pkcs7-mime"},
    {".pbm", "image/x-portable-bitmap"},
    {".ppm", "image/x-portable-pixmap"},
    {".pub", "application/x-mspublisher"},
    {".pnm", "image/x-portable-anymap"},
    {".png", "image/png"},
    {".pml", "application/x-perfmon"},
    {".p10", "application/pkcs10"},
    {".pfx", "application/x-pkcs12"},
    {".p12", "application/x-pkcs12"},
    {".pdf", "application/pdf"},
    {".pps", "application/vnd.ms-powerpoint"},
    {".p7m", "application/pkcs7-mime"},
    {".pko", "application/vndms-pkipko"},
    {".ppt", "application/vnd.ms-powerpoint"},
    {".pmr", "application/x-perfmon"},
    {".pma", "application/x-perfmon"},
    {".pot", "application/vnd.ms-powerpoint"},
    {".prf", "application/pics-rules"},
    {".pgm", "image/x-portable-graymap"},
    {".qt", "video/quicktime"},
    {".ra", "audio/x-pn-realaudio"},
    {".rgb", "image/x-rgb"},
    {".ram", "audio/x-pn-realaudio"},
    {".rmi", "audio/mid"},
    {".ras", "image/x-cmu-raster"},
    {".roff", "application/x-troff"},
    {".rtf", "application/rtf"},
    {".rtx", "text/richtext"},
    {".sv4crc", "application/x-sv4crc"},
    {".spc", "application/x-pkcs7-certificates"},
    {".setreg", "application/set-registration-initiation"},
    {".snd", "audio/basic"},
    {".stl", "application/vndms-pkistl"},
    {".setpay", "application/set-payment-initiation"},
    {".stm", "text/html"},
    {".shar", "application/x-shar"},
    {".sh", "application/x-sh"},
    {".sit", "application/x-stuffit"},
    {".spl", "application/futuresplash"},
    {".sct", "text/scriptlet"},
    {".scd", "application/x-msschedule"},
    {".sst", "application/vndms-pkicertstore"},
    {".src", "application/x-wais-source"},
    {".sv4cpio", "application/x-sv4cpio"},
    {".tex", "application/x-tex"},
    {".tgz", "application/x-compressed"},
    {".t", "application/x-troff"},
    {".tar", "application/x-tar"},
    {".tr", "application/x-troff"},
    {".tif", "image/tiff"},
    {".txt", "text/plain"},
    {".texinfo", "application/x-texinfo"},
    {".trm", "application/x-msterminal"},
    {".tiff", "image/tiff"},
    {".tcl", "application/x-tcl"},
    {".texi", "application/x-texinfo"},
    {".tsv", "text/tab-separated-values"},
    {".ustar", "application/x-ustar"},
    {".uls", "text/iuls"},
    {".vcf", "text/x-vcard"},
    {".wps", "application/vnd.ms-works"},
    {".wav", "audio/wav"},
    {".wrz", "x-world/x-vrml"},
    {".wri", "application/x-mswrite"},
    {".wks", "application/vnd.ms-works"},
    {".wmf", "application/x-msmetafile"},
    {".wcm", "application/vnd.ms-works"},
    {".wrl", "x-world/x-vrml"},
    {".wdb", "application/vnd.ms-works"},
    {".wsdl", "text/xml"},
    {".xap", "application/x-silverlight-app"},
    {".xml", "text/xml"},
    {".xlm", "application/vnd.ms-excel"},
    {".xaf", "x-world/x-vrml"},
    {".xla", "application/vnd.ms-excel"},
    {".xls", "application/vnd.ms-excel"},
    {".xof", "x-world/x-vrml"},
    {".xlt", "application/vnd.ms-excel"},
    {".xlc", "application/vnd.ms-excel"},
    {".xsl", "text/xml"},
    {".xbm", "image/x-xbitmap"},
    {".xlw", "application/vnd.ms-excel"},
    {".xpm", "image/x-xpixmap"},
    {".xwd", "image/x-xwindowdump"},
    {".xsd", "text/xml"},
    {".z", "application/x-compress"},
    {".zip", "application/x-zip-compressed"},
    {".*", "application/octet-stream"}
};
map<string, string> CONTENT_TYPE = {
    {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
    {".xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template"},
    {".potx", "application/vnd.openxmlformats-officedocument.presentationml.template"},
    {".ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow"},
    {".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"},
    {".sldx", "application/vnd.openxmlformats-officedocument.presentationml.slide"},
    {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
    {".dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template"},
    {".xlam", "application/vnd.ms-excel.addin.macroEnabled.12"},
    {".xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12"},
    {".apk", "application/vnd.android.package-archive"},
    {".cpt", "application/mac-compactpro"},
    {".ogg", "application/ogg"},
    {".mif", "application/vnd.mif"},
    {".odc", "application/vnd.oasis.opendocument.chart"},
    {".odb", "application/vnd.oasis.opendocument.database"},
    {".odf", "application/vnd.oasis.opendocument.formula"},
    {".odg", "application/vnd.oasis.opendocument.graphics"},
    {".otg", "application/vnd.oasis.opendocument.graphics-template"},
    {".odi", "application/vnd.oasis.opendocument.image"},
    {".odp", "application/vnd.oasis.opendocument.presentation"},
    {".otp", "application/vnd.oasis.opendocument.presentation-template"},
    {".ots", "application/vnd.oasis.opendocument.spreadsheet-template"},
    {".odt", "application/vnd.oasis.opendocument.text"},
    {".odm", "application/vnd.oasis.opendocument.text-master"},
    {".ott", "application/vnd.oasis.opendocument.text-template"},
    {".oth", "application/vnd.oasis.opendocument.text-web"},
    {".sxw", "application/vnd.sun.xml.writer"},
    {".stw", "application/vnd.sun.xml.writer.template"},
    {".sxc", "application/vnd.sun.xml.calc"},
    {".stc", "application/vnd.sun.xml.calc.template"},
    {".sxd", "application/vnd.sun.xml.draw"},
    {".std", "application/vnd.sun.xml.draw.template"},
    {".sxi", "application/vnd.sun.xml.impress"},
    {".sti", "application/vnd.sun.xml.impress.template"},
    {".sxg", "application/vnd.sun.xml.writer.global"},
    {".sxm", "application/vnd.sun.xml.math"},
    {".sis", "application/vnd.symbian.install"},
    {".wbxml", "application/vnd.wap.wbxml"},
    {".wmlc", "application/vnd.wap.wmlc"},
    {".wmlsc", "application/vnd.wap.wmlscriptc"},
    {".torrent", "application/x-bittorrent"},
    {".bz2", "application/x-bzip2"},
    {".vcd", "application/x-cdlink"},
    {".pgn", "application/x-chess-pgn"},
    {".jar", "application/x-java-archive"},
    {".jnlp", "application/x-java-jnlp-file"},
    {".ksp", "application/x-kspread"},
    {".chrt", "application/x-kchart"},
    {".kil", "application/x-killustrator"},
    {".rpm", "application/x-rpm"},
    {".swf", "application/x-shockwave-flash"},
    {".ms", "application/x-troff-ms"},
    {".wma", "audio/x-ms-wma"},
    {".wax", "audio/x-ms-wax"},
    {".pdb", "chemical/x-pdb"},
    {".xyz", "chemical/x-xyz"},
    {".wbmp", "image/vnd.wap.wbmp"},
    {".ras", "image/x-cmu-raster"},
    {".pnm", "image/x-portable-anymap"},
    {".pbm", "image/x-portable-bitmap"},
    {".pgm", "image/x-portable-graymap"},
    {".ppm", "image/x-portable-pixmap"},
    {".rgb", "image/x-rgb"},
    {".xbm", "image/x-xbitmap"},
    {".xpm", "image/x-xpixmap"},
    {".xwd", "image/x-xwindowdump"},
    {".css", "text/css"},
    {".rtx", "text/richtext"},
    {".tsv", "text/tab-separated-values"},
    {".jad", "text/vnd.sun.j2me.app-descriptor"},
    {".wml", "text/vnd.wap.wml"},
    {".wmls", "text/vnd.wap.wmlscript"},
    {".etx", "text/x-setext"},
    {".mxu", "video/vnd.mpegurl"},
    {".flv", "video/x-flv"},
    {".wm", "video/x-ms-wm"},
    {".wmv", "video/x-ms-wmv"},
    {".wmx", "video/x-ms-wmx"},
    {".wvx", "video/x-ms-wvx"},
    {".avi", "video/x-msvideo"},
    {".movie", "video/x-sgi-movie"},
    {".ice", "x-conference/x-cooltalk"},
    {".3gp", "video/3gpp"},
    {".ai", "application/postscript"},
    {".aif", "audio/x-aiff"},
    {".aifc", "audio/x-aiff"},
    {".aiff", "audio/x-aiff"},
    {".asc", "text/plain"},
    {".atom", "application/atom+xml"},
    {".au", "audio/basic"},
    {".bin", "application/octet-stream"},
    {".cdf", "application/x-netcdf"},
    {".cgm", "image/cgm"},
    {".class", "application/octet-stream"},
    {".dcr", "application/x-director"},
    {".dif", "video/x-dv"},
    {".dir", "application/x-director"},
    {".djv", "image/vnd.djvu"},
    {".djvu", "image/vnd.djvu"},
    {".dll", "application/octet-stream"},
    {".dmg", "application/octet-stream"},
    {".dms", "application/octet-stream"},
    {".dtd", "application/xml-dtd"},
    {".dv", "video/x-dv"},
    {".dxr", "application/x-director"},
    {".eps", "application/postscript"},
    {".exe", "application/octet-stream"},
    {".ez", "application/andrew-inset"},
    {".gram", "application/srgs"},
    {".grxml", "application/srgs+xml"},
    {".gz", "application/x-gzip"},
    {".htm", "text/html"},
    {".html", "text/html"},
    {".ico", "image/x-icon"},
    {".ics", "text/calendar"},
    {".ifb", "text/calendar"},
    {".iges", "model/iges"},
    {".igs", "model/iges"},
    {".jp2", "image/jp2"},
    {".jpe", "image/jpeg"},
    {".jpeg", "image/jpeg"},
    {".jpg", "image/jpeg"},
    {".kar", "audio/midi"},
    {".lha", "application/octet-stream"},
    {".lzh", "application/octet-stream"},
    {".m4a", "audio/mp4a-latm"},
    {".m4p", "audio/mp4a-latm"},
    {".m4u", "video/vnd.mpegurl"},
    {".m4v", "video/x-m4v"},
    {".mac", "image/x-macpaint"},
    {".mathml", "application/mathml+xml"},
    {".mesh", "model/mesh"},
    {".mid", "audio/midi"},
    {".midi", "audio/midi"},
    {".mp4", "video/mp4"},
    {".mpeg", "video/mpeg"},
    {".mpg", "video/mpeg"},
    {".mpga", "audio/mpeg"},
    {".msh", "model/mesh"},
    {".nc", "application/x-netcdf"},
    {".oda", "application/oda"},
    {".ogv", "video/ogv"},
    {".pct", "image/pict"},
    {".pic", "image/pict"},
    {".pict", "image/pict"},
    {".pnt", "image/x-macpaint"},
    {".pntg", "image/x-macpaint"},
    {".ps", "application/postscript"},
    {".qt", "video/quicktime"},
    {".qti", "image/x-quicktime"},
    {".qtif", "image/x-quicktime"},
    {".ram", "audio/x-pn-realaudio"},
    {".rdf", "application/rdf+xml"},
    {".rm", "application/vnd.rn-realmedia"},
    {".roff", "application/x-troff"},
    {".sgm", "text/sgml"},
    {".sgml", "text/sgml"},
    {".silo", "model/mesh"},
    {".skd", "application/x-koan"},
    {".skm", "application/x-koan"},
    {".skp", "application/x-koan"},
    {".skt", "application/x-koan"},
    {".smi", "application/smil"},
    {".smil", "application/smil"},
    {".snd", "audio/basic"},
    {".so", "application/octet-stream"},
    {".svg", "image/svg+xml"},
    {".t", "application/x-troff"},
    {".texi", "application/x-texinfo"},
    {".texinfo", "application/x-texinfo"},
    {".tif", "image/tiff"},
    {".tiff", "image/tiff"},
    {".tr", "application/x-troff"},
    {".txt", "text/plain"},
    {".vrml", "model/vrml"},
    {".vxml", "application/voicexml+xml"},
    {".webm", "video/webm"},
    {".wrl", "model/vrml"},
    {".xht", "application/xhtml+xml"},
    {".xhtml", "application/xhtml+xml"},
    {".xml", "application/xml"},
    {".xsl", "application/xml"},
    {".xslt", "application/xslt+xml"},
    {".xul", "application/vnd.mozilla.xul+xml"},
    {".webp", "image/webp"}
};


map<string, boost::any> Alibabacloud_OSSUtil::Client::getErrMessage(shared_ptr<string> msg) {
  vector<string> fields = {"Code", "Message", "RequestId", "HostId"};
  map<string, boost::any> err_msg_map;
  if (msg) {
    tinyxml2::XMLDocument xml_doc;
    xml_doc.Parse(msg->c_str(), msg->size());
    tinyxml2::XMLElement* ErrorEle = xml_doc.FirstChildElement("Error");
    if (ErrorEle != nullptr) {
      for (const auto& i : fields) {
        tinyxml2::XMLElement* ChildEle = ErrorEle->FirstChildElement(i.c_str());
        if (ChildEle != nullptr) {
          err_msg_map[i] = boost::any(string(ChildEle->GetText()));
        }
      }
    }
  }
  return err_msg_map;
}

map<string, string> Alibabacloud_OSSUtil::Client::toMeta(const shared_ptr<map<string, string>>& val,
                                                         const shared_ptr<string>& prefix) {
  string pf = !prefix ? "" : *prefix;
  map<string, string> result;
  if (val) {
    for (const auto& i: *val) {
      if (i.first.find(pf) != string::npos) {
        result[i.first] = i.second;
      } else {
        result[*prefix + i.first] = i.second;
      }
    }
  }

  return result;
}

map<string, string> Alibabacloud_OSSUtil::Client::parseMeta(const shared_ptr<map<string, string>>& val,
                                                            const shared_ptr<string>& prefix) {
  string pf = !prefix ? "" : *prefix;
  map<string, string> result;
  if (val) {
    for (const auto& i: *val) {
      size_t pf_pos = i.first.find(pf);
      if (pf_pos != string::npos) {
        string key = string(i.first).replace(pf_pos, pf.size(), "");
        result[key] = i.second;
      } else {
        result[i.first] = i.second;
      }
    }
  }

  return result;
}

string Alibabacloud_OSSUtil::Client::getContentType(const shared_ptr<string>& fileName) {
  if (!fileName) {
    return "";
  }
  smatch mat;
  regex_search(*fileName, mat, regex(R"(\.[\w\d\*]*$)"));
  string suffix = mat[0];

  string type;
  if (SYSTEM_CONTENT_TYPE.find(suffix) != SYSTEM_CONTENT_TYPE.end()) {
    type = SYSTEM_CONTENT_TYPE.at(suffix);
  } else {
    type = CONTENT_TYPE.at(suffix);
  }
  return type;
}

string Alibabacloud_OSSUtil::Client::getContentMD5(const shared_ptr<string>& body,
                                                   const shared_ptr<bool>& isEnableMD5) {
  if (isEnableMD5 && body && *isEnableMD5) {
    MD5 md5 = MD5(*body);
    uint8_t buf[16];
    md5.get_digest(buf);
    return base64::encode_from_array(buf, 16);
  } else {
    return "";
  }
}

string url_encode(const std::string& str) {
  std::stringstream escaped;
  escaped.fill('0');
  escaped << hex;

  for (char c : str) {
    if (isalnum(c) || c == '-' || c == '_' || c == '.' || c == '~') {
      escaped << c;
      continue;
    }
    escaped << std::uppercase;
    escaped << '%' << std::setw(2) << int((unsigned char)c);
    escaped << nouppercase;
  }

  return escaped.str();
}

char from_hex(char ch) {
  return isdigit(ch) ? ch - '0' : tolower(ch) - 'a' + 10;
}

string url_decode(string text) {
  char h;
  ostringstream escaped;
  escaped.fill('0');

  for (auto i = text.begin(), n = text.end(); i != n; ++i) {
    string::value_type c = (*i);

    if (c == '%') {
      if (i[1] && i[2]) {
        h = from_hex(i[1]) << 4 | from_hex(i[2]);
        escaped << h;
        i += 2;
      }
    } else if (c == '+') {
      escaped << ' ';
    } else {
      escaped << c;
    }
  }

  return escaped.str();
}

string Alibabacloud_OSSUtil::Client::encode(const shared_ptr<string>& val,
                                            const shared_ptr<string>& encodeType) {
  string value;
  if (val) {
    value = *val;
  }

  if (!encodeType || encodeType->empty()) {
    return value;
  }

  vector<string> strs;
  if (*encodeType == "Base64") {
    boost::split(strs, value, boost::is_any_of("/"));
    strs[strs.size() -1] = base64::encode_from_string(strs[strs.size() -1]);
  } else if (*encodeType == "UrlEncode") {
    boost::split(strs, value, boost::is_any_of("/"));
    strs[strs.size() -1] = url_encode(strs[strs.size() -1]);
  }
  return boost::join(strs, "/");
}

string Alibabacloud_OSSUtil::Client::getHost(const shared_ptr<string>& bucketName,
                                             shared_ptr<string> regionId,
                                             shared_ptr<string> endpoint,
                                             const shared_ptr<string>& hostModel) {
  string region_id;
  string domain_name;
  if (!regionId || regionId->empty()) {
    region_id = "cn-hangzhou";
  } else {
    region_id = *regionId;
  }

  if (!endpoint || endpoint->empty()) {
    domain_name = "oss-" + region_id + ".aliyuncs.com";
  } else {
    domain_name = *endpoint;
  }

  string host;
  if (bucketName && !bucketName->empty()) {
    if (hostModel && *hostModel == "ip") {
      host = domain_name + "/" + *bucketName;
    } else if (hostModel && *hostModel == "cname") {
      host = domain_name;
    } else {
      host = *bucketName + "." + domain_name;
    }
  } else {
    host = domain_name;
  }
  return host;
}

shared_ptr<Alibabacloud_OSSUtil::VerifyStream> Alibabacloud_OSSUtil::Client::inject(const shared_ptr<Darabonba::Stream>& body,
                                                                        const shared_ptr<map<string, string>>& res) {
  if (body && res) {
    return make_shared<Alibabacloud_OSSUtil::VerifyStream>(body, res);
  }
  return make_shared<Alibabacloud_OSSUtil::VerifyStream>();
}

string signature_v1(Darabonba::Request req, string resource, string secret) {
  vector<string> sorted_keys;
  map<string, string> tmp;
  for (const auto& i : req.headers) {
    string key = boost::algorithm::to_lower_copy(i.first);
    if (boost::starts_with(key, "x-oss-")) {
      tmp[key] = i.second;
      sorted_keys.push_back(key);
    }
  }
  sort(sorted_keys.begin(), sorted_keys.end());
  string oss_key_str;
  for (const auto& i : sorted_keys) {
    oss_key_str += i + ":" + tmp.at(i) + "\n";
  }
  string date;
  string content_type;
  string content_md5;
  if (req.headers.find("date") != req.headers.end()) {
    date = req.headers.at("date");
  }
  if (req.headers.find("content-type") != req.headers.end()) {
    content_type = req.headers.at("content-type");
  }
  if (req.headers.find("content-md5") != req.headers.end()) {
    content_md5 = req.headers.at("content-md5");
  }

  string sign_str = req.method + "\n" + content_md5 + "\n" + content_type + "\n" + date + "\n" + oss_key_str + resource;

  boost::uint8_t hash_val[sha1::HASH_SIZE];
  hmac<sha1>::calc(sign_str, secret, hash_val);
  return base64::encode_from_array(hash_val, sha1::HASH_SIZE);
}

string signature_v2(Darabonba::Request req, string bucketName, string secret, vector<string> addtionalHeaders) {
  string resource;
  string pathname;
  if (bucketName.empty()) {
    pathname = req.pathname;
  } else {
    pathname = "/" + bucketName + req.pathname;
  };

  vector<string> query_sorted_keys;
  for (const auto& i : req.query) {
    query_sorted_keys.push_back(i.first);
  }

  vector<string> strs;
  boost::split(strs, pathname, boost::is_any_of("?"));
  resource += url_encode(strs[0]);

  if (regex_search(pathname, regex("\\?"))) {
    query_sorted_keys.push_back(strs[1]);
  }

  sort(query_sorted_keys.begin(), query_sorted_keys.end());
  if (!query_sorted_keys.empty()) {
    resource += "?";
  }

  for (const auto& key : query_sorted_keys) {
    if (req.query.find(key) != req.query.end()) {
      if (boost::ends_with(resource, "?")) {
        resource += url_encode(key) + "=" + url_encode(req.query.at(key));
      } else {
        resource += "&" + url_encode(key) + "=" + url_encode(req.query.at(key));
      }
    } else {
      if (boost::ends_with(resource, "?")) {
        resource += url_encode(key);
      } else {
        resource += "&" + url_encode(key);
      }
    }
  }

  vector<string> header_sorted_keys;
  map<string, string> tmp;
  for (auto i : req.headers) {
    string key = boost::algorithm::to_lower_copy(i.first);
    if (boost::starts_with(key, "x-oss-")) {
      tmp[key] = i.second;
      header_sorted_keys.push_back(key);
    }
  }
  sort(header_sorted_keys.begin(), header_sorted_keys.end());

  string can_oss_headers;
  for (const auto& key : header_sorted_keys) {
    can_oss_headers += key + ":" + tmp.at(key) + "\n";
  }

  string date;
  string content_type;
  string content_md5;
  if (req.headers.find("date") != req.headers.end()) {
    date = req.headers.at("date");
  }
  if (req.headers.find("content-type") != req.headers.end()) {
    content_type = req.headers.at("content-type");
  }
  if (req.headers.find("content-md5") != req.headers.end()) {
    content_md5 = req.headers.at("content-md5");
  }

  string sign_str = req.method + "\n" + content_md5 + "\n" + content_type + "\n" + date + "\n" + can_oss_headers + boost::join(addtionalHeaders, ";") + "\n" + resource;

  boost::uint8_t hash_val[sha256::HASH_SIZE];
  hmac<sha256>::calc(sign_str, secret, hash_val);
  return base64::encode_from_array(hash_val, sha256::HASH_SIZE);
}

string Alibabacloud_OSSUtil::Client::getSignature(const shared_ptr<Darabonba::Request>& request,
                                                  const shared_ptr<string>& bucketName,
                                                  const shared_ptr<string>& accessKeyId,
                                                  const shared_ptr<string>& accessKeySecret,
                                                  const shared_ptr<string>& signatureVersion,
                                                  const shared_ptr<vector<string>>& addtionalHeaders) {
  string signature;
  if (!request) {
    return signature;
  }
  string signature_version = !signatureVersion ? "v1" : *signatureVersion;
  Darabonba::Request req = !request ? Darabonba::Request() : *request;
  string ak_id = !accessKeyId ? "" : *accessKeyId;
  string ak_secret = !accessKeySecret? "" : *accessKeySecret;

  if (signature_version == "v1") {
    string resource;
    if (bucketName) {
      resource = "/" + *bucketName;
    }

    resource += request->pathname;

    if (!request->query.empty() && !regex_search(resource, regex("\\?"))) {
      resource += "?";
    }

    vector<string> sorted_query_keys;
    for (const auto& i : request->query) {
      sorted_query_keys.push_back(i.first);
    }
    sort(sorted_query_keys.begin(), sorted_query_keys.end());

    for (const auto& key : sorted_query_keys) {
      string value = request->query.at(key);
      if (find(SIGN_KEY_LIST.begin(), SIGN_KEY_LIST.end(), key) != SIGN_KEY_LIST.end() && !value.empty()) {
        if (boost::ends_with(resource, "?")) {
          resource.append(key).append("=").append(value);
        } else {
          resource.append("&").append(key).append("=").append(value);
        }
      }
    }
    signature = "OSS " + *accessKeyId + ":" + signature_v1(*request, resource, *accessKeySecret);
  } else {

    if (addtionalHeaders && !addtionalHeaders->empty()) {
      string signature2 = signature_v2(*request, *bucketName, *accessKeySecret, *addtionalHeaders);
      signature = "OSS2 AccessKeyId:" + *accessKeyId + ",AdditionalHeaders:" + boost::join(*addtionalHeaders, ";") + ",Signature:" + signature2;
    } else {
      vector<string> headers;
      string signature2 = signature_v2(*request, *bucketName, *accessKeySecret, headers);
      signature = "OSS2 AccessKeyId:" + *accessKeyId + ",Signature:" + signature2;
    }
  }
  return signature;
}


string Alibabacloud_OSSUtil::Client::decode(const shared_ptr<string>& val, shared_ptr<string> decodeType) {
  string strs;
  if (val) {
    strs = *val;
    if (*decodeType == "Base64Decode") {
      string decoded_str;
      base64::decode(strs, decoded_str);
      return decoded_str;
    } else if (*decodeType == "UrlDecode") {
      return url_decode(strs);
    }
  }
  return strs;
}

bool Alibabacloud_OSSUtil::VerifyStream::empty() {
  return _stream->empty();
}

string Alibabacloud_OSSUtil::VerifyStream::read() {
  string result = _stream->read();

  boost::crc_optimal<64, 0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, 0xFFFFFFFFFFFFFFFF, true, true> crc64;
  crc64.process_bytes(result.c_str(), result.size());

  _ctx->insert(make_pair("crc", to_string(crc64.checksum())));
  MD5 md5 = MD5(result);
  uint8_t buf[16];
  md5.get_digest(buf);
  _ctx->insert(make_pair("md5", base64::encode_from_array(buf, 16)));
  return result;
}
