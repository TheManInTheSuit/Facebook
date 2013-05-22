using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class PricePoint
        {
            [DataMember(Name = "user_price")]
            public string UserPrice { get; set; }

            [DataMember(Name = "user_price")]
            public double? Credits { get; set; }

            [DataMember(Name = "user_price")]
            public string LocalCurrency { get; set; }
        }
    }
}