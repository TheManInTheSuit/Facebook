using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Group
        {
            /// <summary>
            /// Name: id
            /// Description: The group ID
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: icon
            /// Description: The URL for the group's icon
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "icon")]
            public string Icon { get; set; }

            /// <summary>
            /// Name: cover
            /// Description: The URL for the group's cover photo
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: array containing a valid URL, cover_id and image offset
            /// </summary>
            [DataMember(Name = "cover")]
            public GraphApi.Cover[] Cover { get; set; }

            /// <summary>
            /// Name: owner
            /// Description: The profile that created this group
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: object containing the id and name fields
            /// </summary>
            [DataMember(Name = "owner")]
            public GraphApi.Domain Owner { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The name of the group
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: description
            /// Description: A brief description of the group
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: string
            /// </summary>
            [DataMember(Name = "description")]
            public string Description { get; set; }

            /// <summary>
            /// Name: link
            /// Description: The URL for the group's website
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "link")]
            public string Link { get; set; }

            /// <summary>
            /// Name: privacy
            /// Description: The privacy setting of the group
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: string containing OPEN, CLOSED, or SECRET
            /// </summary>
            [DataMember(Name = "privacy")]
            public string Privacy { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: The last time the group was updated
            /// Permissions: generic access_token, user_groups, or friends_groups
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }
        }
    }
}