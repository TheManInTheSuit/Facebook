using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class AchievementInstance
        {
            /// <summary>
            /// Name: id
            /// Description: id of the achievement(instance)
            /// Permissions: app or user access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The user who achieved the achievement
            /// Permissions: app or user access_token
            /// Return: object containing the id and name of user
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: Time at which the achievement was achieved
            /// Permissions: app or user access_token
            /// Return: string containing an ISO-8601 datetime
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: application
            /// Description: The application in which the user achieved the achievement
            /// Permissions: app or user access_token
            /// Return: object containing id and name of application
            /// </summary>
            [DataMember(Name = "application")]
            public GraphAPI.Domain Application { get; set; }

            /// <summary>
            /// Name: achievement
            /// Description: The achievement object that the user achieved
            /// Permissions: app or user access_token
            /// Return: object containing the id, url, type, and title of the achievement
            /// </summary>
            [DataMember(Name = "achievement")]
            public GraphAPI.Achievement Achievement { get; set; }

            /// <summary>
            /// Name: likes
            /// Description: likes received by the story
            /// Permissions: app or user access_token
            /// Return: object containing the count of likes, as well as an array containing the name and id of users who like it
            /// </summary>
            [DataMember(Name = "likes")]
            public GraphAPI.Array<GraphAPI.Domain> Likes { get; set; }

            /// <summary>
            /// Name: comments
            /// Description: Comments received by the achievement story
            /// Permissions: app or user access_token
            /// Return: object containing the count of comments, as well as an array containing id of the comment, from object containing the name and id of users who created the comment, message and created_time of the comment
            /// </summary>
            [DataMember(Name = "comments")]
            public GraphAPI.Array<GraphAPI.MessageObject> Comments { get; set; }
        }
    }
}
