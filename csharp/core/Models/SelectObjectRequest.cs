// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class SelectObjectRequest : TeaModel {
        /// <summary>
        /// BucketName
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9\\-\\_]+")]
        public string BucketName { get; set; }

        /// <summary>
        /// ObjectName
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=true)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Filter
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=true)]
        public SelectObjectRequestFilter Filter { get; set; }
        public class SelectObjectRequestFilter : TeaModel {
            [NameInMap("x-oss-process")]
            [Validation(Required=true)]
            public string Porcess { get; set; }
        };

        /// <summary>
        /// Body
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public SelectObjectRequestBody Body { get; set; }
        public class SelectObjectRequestBody : TeaModel {
            [NameInMap("SelectRequest")]
            [Validation(Required=true)]
            public SelectObjectRequestBodySelectRequest SelectRequest { get; set; }
            public class SelectObjectRequestBodySelectRequest : TeaModel {
                /// <summary>
                /// InputSerialization
                /// </summary>
                [NameInMap("InputSerialization")]
                [Validation(Required=false)]
                public SelectObjectRequestBodySelectRequestInputSerialization InputSerialization { get; set; }
                public class SelectObjectRequestBodySelectRequestInputSerialization : TeaModel {
                    [NameInMap("CSV")]
                    [Validation(Required=false)]
                    public SelectObjectRequestBodySelectRequestInputSerializationCSV CSV { get; set; }
                    public class SelectObjectRequestBodySelectRequestInputSerializationCSV : TeaModel {
                        /// <summary>
                        /// FileHeaderInfo
                        /// </summary>
                        [NameInMap("FileHeaderInfo")]
                        [Validation(Required=false)]
                        public string FileHeaderInfo { get; set; }

                        /// <summary>
                        /// RecordDelimiter
                        /// </summary>
                        [NameInMap("RecordDelimiter")]
                        [Validation(Required=false)]
                        public string RecordDelimiter { get; set; }

                        /// <summary>
                        /// FieldDelimiter
                        /// </summary>
                        [NameInMap("FieldDelimiter")]
                        [Validation(Required=false)]
                        public string FieldDelimiter { get; set; }

                        /// <summary>
                        /// QuoteCharacter
                        /// </summary>
                        [NameInMap("QuoteCharacter")]
                        [Validation(Required=false)]
                        public string QuoteCharacter { get; set; }

                        /// <summary>
                        /// CommentCharacter
                        /// </summary>
                        [NameInMap("CommentCharacter")]
                        [Validation(Required=false)]
                        public string CommentCharacter { get; set; }

                        /// <summary>
                        /// Range
                        /// </summary>
                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public string Range { get; set; }

                    }
                    [NameInMap("CompressionType")]
                    [Validation(Required=false)]
                    public string CompressionType { get; set; }
                };

                /// <summary>
                /// OutputSerialization
                /// </summary>
                [NameInMap("OutputSerialization")]
                [Validation(Required=false)]
                public SelectObjectRequestBodySelectRequestOutputSerialization OutputSerialization { get; set; }
                public class SelectObjectRequestBodySelectRequestOutputSerialization : TeaModel {
                    [NameInMap("CSV")]
                    [Validation(Required=false)]
                    public SelectObjectRequestBodySelectRequestOutputSerializationCSV CSV { get; set; }
                    public class SelectObjectRequestBodySelectRequestOutputSerializationCSV : TeaModel {
                        /// <summary>
                        /// RecordDelimiter
                        /// </summary>
                        [NameInMap("RecordDelimiter")]
                        [Validation(Required=false)]
                        public string RecordDelimiter { get; set; }

                        /// <summary>
                        /// FieldDelimiter
                        /// </summary>
                        [NameInMap("FieldDelimiter")]
                        [Validation(Required=false)]
                        public string FieldDelimiter { get; set; }

                    }
                    [NameInMap("KeepAllColumns")]
                    [Validation(Required=false)]
                    public string KeepAllColumns { get; set; }
                    [NameInMap("OutputRawData")]
                    [Validation(Required=false)]
                    public string OutputRawData { get; set; }
                    [NameInMap("EnablePayloadCrc")]
                    [Validation(Required=false)]
                    public string EnablePayloadCrc { get; set; }
                    [NameInMap("OutputHeader")]
                    [Validation(Required=false)]
                    public string OutputHeader { get; set; }
                };

                /// <summary>
                /// Options
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public SelectObjectRequestBodySelectRequestOptions Options { get; set; }
                public class SelectObjectRequestBodySelectRequestOptions : TeaModel {
                    [NameInMap("SkipPartialDataRecord")]
                    [Validation(Required=false)]
                    public string SkipPartialDataRecord { get; set; }
                    [NameInMap("MaxSkippedRecordsAllowed")]
                    [Validation(Required=false)]
                    public string MaxSkippedRecordsAllowed { get; set; }
                };

                /// <summary>
                /// Expression
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

            }
        };

    }

}
