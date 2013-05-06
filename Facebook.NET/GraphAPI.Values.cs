using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Values
        {
            [DataMember(Name = "value")]
            public string Value { get; set; }

            [DataMember(Name = "end_time")]
            public string EndTime { get; set; }
        }
    }
}
