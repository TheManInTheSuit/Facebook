using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class LinkObject
        {
            /// <summary>
            /// Name: id
            /// Description: The link ID
            /// Permissions: generic access_token or read_stream
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The user that created the link
            /// Permissions: generic access_token or read_stream
            /// Return: Object containing the id and name field
            /// </summary>
            [DataMember(Name = "from")]
            public GraphApi.Domain From { get; set; }

            /// <summary>
            /// Name: link
            /// Description: The URL that was shared
            /// Permissions: generic access_token or read_stream
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "link")]
            public string Link { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The name of the link
            /// Permissions: generic access_token or read_stream
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: comments
            /// Description: All of the comments on this link
            /// Permissions: read_stream
            /// Return: Array of objects containing id, from, message and created_time fields
            /// </summary>
            [DataMember(Name = "comments")]
            public GraphApi.Comment[] Comments { get; set; }

            /// <summary>
            /// Name: description
            /// Description: A description of the link (appears beneath the link caption)
            /// Permissions: generic access_token or read_stream
            /// Return: string
            /// </summary>
            [DataMember(Name = "description")]
            public string Description { get; set; }

            /// <summary>
            /// Name: icon
            /// Description: A URL to the link icon that Facebook displays in the news feed
            /// Permissions: generic access_token or read_stream
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "icon")]
            public string Icon { get; set; }

            /// <summary>
            /// Name: picture
            /// Description: A URL to the thumbnail image used in the link post
            /// Permissions: generic access_token or read_stream
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "picture")]
            public string Picture { get; set; }

            /// <summary>
            /// Name: message
            /// Description: The optional message from the user about this link
            /// Permissions: generic access_token or read_stream
            /// Return: string
            /// </summary>
            [DataMember(Name = "message")]
            public string Message { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: The time the message was published
            /// Permissions: generic access_token or read_stream
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: type
            /// Description: The type of this object; always returns link
            /// Permissions: generic access_token or read_stream
            /// Return: string
            /// </summary>
            [DataMember(Name = "type")]
            public string Type { get; set; }
        }
    }
}