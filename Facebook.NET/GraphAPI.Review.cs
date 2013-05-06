using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Review
        {
            /// <summary>
            /// Name: id
            /// Description: The Facebook ID of the review
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The user that created the review
            /// Permissions: No access_token required
            /// Return: object containing the id and name of the creating user
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: to
            /// Description: The application to which this review applies
            /// Permissions: No access_token required
            /// Return: object containing the id and name of the application
            /// </summary>
            [DataMember(Name = "to")]
            public GraphAPI.Domain To { get; set; }

            /// <summary>
            /// Name: message
            /// Description: The review text (optional)
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "message")]
            public string Message { get; set; }

            /// <summary>
            /// Name: rating
            /// Description: The review rating
            /// Permissions: No access_token required
            /// Return: int between 1 and 5
            /// </summary>
            [DataMember(Name = "rating")]
            public int? Rating { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: The timedate the review was created
            /// Permissions: No access_token required
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }
        }
    }
}
