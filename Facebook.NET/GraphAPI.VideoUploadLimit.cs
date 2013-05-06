using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class VideoUploadLimit
        {
            [DataMember(Name = "length")]
            public double? Length { get; set; }

            [DataMember(Name = "size")]
            public long? Size { get; set; }
        }
    }
}
