using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Cover
        {
            [DataMember(Name = "cover_id")]
            public string ID { get; set; }

            [DataMember(Name = "source")]
            public string Source { get; set; }

            [DataMember(Name = "offset_x")]
            public double? OffsetX { get; set; }

            [DataMember(Name = "offset_y")]
            public double? OffsetY { get; set; }
        }
    }
}