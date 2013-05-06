using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed partial class Account
        {
            [DataMember(Name = "data")]
            public GraphAPI.AccountData[] Data { get; set; }

            [DataMember(Name = "paging")]
            public GraphAPI.Pagination Paging { get; set; }
        }
    }
}
