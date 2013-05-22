using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Offer
        {
            /// <summary>
            /// Name: id
            /// Description: The offer ID
            /// Permissions: access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The ID, category, and name of the page that published the offer
            /// Permissions: access_token
            /// Return: object containing the id, category, and name fields
            /// </summary>
            [DataMember(Name = "from")]
            public GraphApi.Page From { get; set; }

            /// <summary>
            /// Name: title
            /// Description: The title of the offer
            /// Permissions: access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "title")]
            public string Title { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: The time the offer was created
            /// Permissions: access_token
            /// Return: string containing ISO-8601 date-time datetime
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: expiration_time
            /// Description: The expiration time of the offer (for display purposes)
            /// Permissions: access_token
            /// Return: string containing ISO-8601 date-time datetime
            /// </summary>
            [DataMember(Name = "expiration_time")]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// Name: terms
            /// Description: The terms of the offer
            /// Permissions: access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "terms")]
            public string Terms { get; set; }

            /// <summary>
            /// Name: image_url
            /// Description: The URL for the offer's image
            /// Permissions: access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "image_url")]
            public string ImageUrl { get; set; }

            /// <summary>
            /// Name: coupon_type
            /// Description: The type of offer
            /// Permissions: access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "coupon_type")]
            public string CouponType { get; set; }

            /// <summary>
            /// Name: claim_limit
            /// Description: The maximum number of times the offer can be claimed
            /// Permissions: access_token
            /// Return: integer
            /// </summary>
            [DataMember(Name = "claim_limit")]
            public int ClaimLimit { get; set; }

            /// <summary>
            /// Name: redemption_link
            /// Description: The URL where the offer may be redeemed
            /// Permissions: access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "redemption_link")]
            public string RedemptionLink { get; set; }

            /// <summary>
            /// Name: redemption_code
            /// Description: A code to to receive the discount or promotion
            /// Permissions: access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "redemption_code")]
            public string RedemptionCode { get; set; }
        }
    }
}