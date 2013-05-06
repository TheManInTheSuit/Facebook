using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Array<T>
        {
            [DataMember(Name = "count")]
            public int Count { get; set; }

            [DataMember(Name = "items")]
            public T[] Items { get; set; }
        }
    }
}
