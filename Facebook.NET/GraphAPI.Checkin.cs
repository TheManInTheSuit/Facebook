using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Checkin
        {
            /// <summary>
            /// Name: id
            /// Description: The checkin ID
            /// Permissions: user_checkins
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The ID and name of the user who made the checkin
            /// Permissions: user_checkins
            /// Return: object containing the id and name fields
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: tags
            /// Description: The users the author tagged in the checkin
            /// Permissions: user_checkins
            /// Return: array of objects containing the id and name fields
            /// </summary>
            [DataMember(Name = "tags")]
            public GraphAPI.Domain[] Tags { get; set; }

            /// <summary>
            /// Name: place
            /// Description: Information about the Facebook Page that represents the location of the checkin
            /// Permissions: user_checkins
            /// Return: object containing the Page id, name, and location; location includes the specific latitude and longitude along with information about the postal addresses, if available
            /// </summary>
            [DataMember(Name = "place")]
            public Venue Place { get; set; }

            /// <summary>
            /// Name: application
            /// Description: Information about the application that made the checkin
            /// Permissions: user_checkins
            /// Return: object that contains the name and id, canvas_name, and namespace of the application
            /// </summary>
            [DataMember(Name = "application")]
            public Application Application { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: The time the checkin was created
            /// Permissions: user_checkins
            /// Return: string containing ISO-8601 date-time datetime
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: likes
            /// Description: Users who like the checkin
            /// Permissions: user_checkins
            /// Return: array of objects containing id and name fields
            /// </summary>
            [DataMember(Name = "likes")]
            public GraphAPI.Domain[] Likes { get; set; }

            /// <summary>
            /// Name: message
            /// Description: The message the user added to the checkin
            /// Permissions: user_checkins
            /// Return: string
            /// </summary>
            [DataMember(Name = "message")]
            public string Message { get; set; }

            /// <summary>
            /// Name: comments
            /// Description: All of the comments on this link
            /// Permissions: user_checkins
            /// Return: Array of objects containing id, from, message and created_time fields
            /// </summary>
            [DataMember(Name = "comments")]
            public MessageObject[] Comments { get; set; }

            /// <summary>
            /// Name: type
            /// Description: The type of this object; always returns checkin
            /// Permissions: user_checkins
            /// Return: string
            /// </summary>
            [DataMember(Name = "type")]
            public string Type { get; set; }
        }
    }
}
