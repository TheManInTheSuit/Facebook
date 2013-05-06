using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Status
        {
            /// <summary>
            /// Name: id
            /// Description: The status message ID
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The user who posted the message
            /// Permissions: Requires access_token
            /// Return: object containing id and name fields
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: message
            /// Description: The status message content
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "message")]
            public string Message { get; set; }

            /// <summary>
            /// Name: place
            /// Description: Location associated with a Status, if any
            /// Permissions: Requires access_token
            /// Return: object containing id and name of Page associated with this location, and a location field containing geographic information such as latitude, longitude, country, and other fields (fields will vary based on geography and availability of information)
            /// </summary>
            [DataMember(Name = "place")]
            public GraphAPI.Venue Place { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: The time the message was published
            /// Permissions: Requires access_token
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: type
            /// Description: The object type which is set to status
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "type")]
            public string Type { get; set; }
        }
    }
}
