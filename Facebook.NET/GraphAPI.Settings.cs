using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Settings
        {
            [DataMember(Name = "enabled")]
            public bool? Enabled { get; set; }
        }
    }
}
