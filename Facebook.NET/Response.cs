using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public class Response<T>
        {
            [DataMember(Name = "error")]
            public GraphApi.Error Error { get; set; }

            [DataMember(Name = "data")]
            public T Data { get; set; }
        }
    }
}