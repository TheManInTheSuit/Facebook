using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Order
        {
            /// <summary>
            /// Name: id
            /// Description: id for the order
            /// Permissions: app access_token
            /// Return: name and id of the user
            /// </summary>
            [DataMember(Name = "id")]
            public GraphAPI.Domain ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: userid associated with the order unless the user has uninstalled, in which case we return a third_party_id
            /// Permissions: app access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "from")]
            public string From { get; set; }

            /// <summary>
            /// Name: amount
            /// Description: amount for the order
            /// Permissions: app access_token
            /// Return: integer
            /// </summary>
            [DataMember(Name = "amount")]
            public int? Amount { get; set; }

            /// <summary>
            /// Name: status
            /// Description: status the order
            /// Permissions: app access_token
            /// Return: string - possible values are placed, settled, disputed, refunded, cancelled
            /// </summary>
            [DataMember(Name = "status")]
            public string Status { get; set; }

            /// <summary>
            /// Name: application
            /// Description: application associated with the order
            /// Permissions: app access_token
            /// Return: name and id of the application
            /// </summary>
            [DataMember(Name = "application")]
            public GraphAPI.Domain Application { get; set; }

            /// <summary>
            /// Name: country
            /// Description: country associated with the order
            /// Permissions: app access_token
            /// Return: String containing ISO 3166 alpha 2 code representing the country
            /// </summary>
            [DataMember(Name = "country")]
            public string Country { get; set; }

            /// <summary>
            /// Name: refund_reason_code
            /// Description: refund reason code if the order was refunded by Facebook
            /// Permissions: app access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "refund_reason_code")]
            public string RefundReasonCode { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: time when the order was created
            /// Permissions: app access_token
            /// Return: string containing an ISO-8601 datetime
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: time when the order was last updated
            /// Permissions: app access_token
            /// Return: string containing an ISO-8601 datetime
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }
        }
    }
}
