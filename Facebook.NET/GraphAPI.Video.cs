using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Video
        {
            /// <summary>
            /// Name: id
            /// Description: The video ID
            /// Permissions: user_videos
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The profile (user or page) that created the video
            /// Permissions: user_videos
            /// Return: object containing id and name fields
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: tags
            /// Description: The users who are tagged in this video
            /// Permissions: user_videos
            /// Return: array of objects containing id and name fields
            /// </summary>
            [DataMember(Name = "tags")]
            public GraphAPI.Domain[] Tags { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The video title or caption
            /// Permissions: user_videos
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: description
            /// Description: The description of the video
            /// Permissions: user_videos
            /// Return: string
            /// </summary>
            [DataMember(Name = "description")]
            public string Description { get; set; }

            /// <summary>
            /// Name: picture
            /// Description: The URL for the thumbnail picture for the video
            /// Permissions: user_videos
            /// Return: string
            /// </summary>
            [DataMember(Name = "picture")]
            public string Picture { get; set; }

            /// <summary>
            /// Name: embed_html
            /// Description: The html element that may be embedded in an Web page to play the video
            /// Permissions: user_videos
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "embed_html")]
            public string EmbedHtml { get; set; }

            /// <summary>
            /// Name: icon
            /// Description: The icon that Facebook displays when video are published to the Feed
            /// Permissions: user_videos
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "icon")]
            public string Icon { get; set; }

            /// <summary>
            /// Name: source
            /// Description: A URL to the raw, playable video file
            /// Permissions: user_videos
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "source")]
            public string Source { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: The time the video was initially published
            /// Permissions: user_videos
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: The last time the video or its caption were updated
            /// Permissions: user_videos
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: comments
            /// Description: All of the comments on this video
            /// Permissions: user_videos
            /// Return: array of objects containing id, from, message, created_time, and likes fields
            /// </summary>
            [DataMember(Name = "comments")]
            public GraphAPI.Comment[] Comments { get; set; }
        }
    }
}
