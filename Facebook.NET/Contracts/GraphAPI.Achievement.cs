using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Achievement
        {
            [DataMember(Name = "id")]
            public string ID { get; set; }

            [DataMember(Name = "url")]
            public string Url { get; set; }

            [DataMember(Name = "type")]
            public string Type { get; set; }

            [DataMember(Name = "title")]
            public string Title { get; set; }
        }
    }
}