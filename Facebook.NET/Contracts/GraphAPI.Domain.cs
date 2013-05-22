using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Domain : IObject
        {
            [DataMember(Name = "id")]
            public string ID { get; set; }

            [DataMember(Name = "name")]
            public string Name { get; set; }
        }
    }
}