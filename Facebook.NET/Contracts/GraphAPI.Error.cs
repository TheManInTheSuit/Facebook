using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Error
        {
            [DataMember(Name = "message")]
            public string Message { get; set; }

            [DataMember(Name = "type")]
            public string Type { get; set; }

            [DataMember(Name = "code")]
            public string Code { get; set; }

            [DataMember(Name = "error_subcode")]
            public string ErrorSubcode { get; set; }
        }
    }
}