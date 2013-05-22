using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class SecuritySettings
        {
            [DataMember(Name = "secure_browsing")]
            public Settings SecureBrowsing { get; set; }
        }
    }
}