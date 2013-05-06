using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public class Response<T>
        {
            [DataMember(Name = "error")]
            public GraphAPI.Error Error { get; set; }

            [DataMember(Name = "data")]
            public T Data { get; set; }
        }
    }
}
