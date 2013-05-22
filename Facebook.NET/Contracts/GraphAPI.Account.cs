using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed partial class Account
        {
            [DataMember(Name = "data")]
            public GraphApi.AccountData[] Data { get; set; }

            [DataMember(Name = "paging")]
            public GraphApi.Pagination Paging { get; set; }
        }
    }
}