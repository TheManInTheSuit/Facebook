using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Education
        {
            [DataMember(Name = "school")]
            public Domain School { get; set; }

            [DataMember(Name = "year")]
            public Domain Year { get; set; }

            [DataMember(Name = "type")]
            public string Type { get; set; }

            [DataMember(Name = "concentration")]
            public GraphAPI.Domain Concentration { get; set; }
        }
    }
}
