using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Currency
        {
            [DataMember(Name = "user_currency")]
            public string UserCurrency { get; set; }

            [DataMember(Name = "currency_exchange")]
            public double? CurrencyExchange { get; set; }

            [DataMember(Name = "currency_exchange_inverse")]
            public double? CurrencyExchangeInverse { get; set; }

            [DataMember(Name = "usd_exchange")]
            public double? UsdExchange { get; set; }

            [DataMember(Name = "usd_exchange_inverse")]
            public double? UsdExchangeInverse { get; set; }

            [DataMember(Name = "currency_offset")]
            public double? CurrencyOffset { get; set; }
        }
    }
}