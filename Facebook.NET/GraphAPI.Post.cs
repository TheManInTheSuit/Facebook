using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Post
        {
            /// <summary>
            /// Name: id
            /// Description: The post ID
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: Information about the user who posted the message
            /// Permissions: Requires access_token
            /// Return: object containing the name and Facebook id of the user who posted the message
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: to
            /// Description: Profiles mentioned or targeted in this post
            /// Permissions: Requires access_token
            /// Return: Contains in data an array of objects, each with the name and Facebook id of the user
            /// </summary>
            [DataMember(Name = "to")]
            public GraphAPI.Domain[] To { get; set; }

            /// <summary>
            /// Name: message
            /// Description: The message
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "message")]
            public string Message { get; set; }

            /// <summary>
            /// Name: message_tags
            /// Description: Objects tagged in the message (Users, Pages, etc)
            /// Permissions: Requires access_token
            /// Return: object containing fields whose names are the indexes to where objects are mentioned in the message field; each field in turn is an array containing an object with id, name, offset, and length fields, where length is the length, within the message field, of the object mentioned
            /// </summary>
            [DataMember(Name = "message_tags")]
            public object[] MessageTags { get; set; }

            /// <summary>
            /// Name: picture
            /// Description: If available, a link to the picture included with this post
            /// Permissions: Requires access_token
            /// Return: link
            /// </summary>
            [DataMember(Name = "picture")]
            public string Picture { get; set; }

            /// <summary>
            /// Name: link
            /// Description: The link attached to this post
            /// Permissions: Requires access_token
            /// Return: string containing the URL
            /// </summary>
            [DataMember(Name = "link")]
            public string Link { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The name of the link
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: caption
            /// Description: The caption of the link (appears beneath the link name)
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "caption")]
            public string Caption { get; set; }

            /// <summary>
            /// Name: description
            /// Description: A description of the link (appears beneath the link caption)
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "description")]
            public string Description { get; set; }

            /// <summary>
            /// Name: source
            /// Description: A URL to a Flash movie or video file to be embedded within the post
            /// Permissions: Requires access_token
            /// Return: string containing the URL
            /// </summary>
            [DataMember(Name = "source")]
            public string Source { get; set; }

            /// <summary>
            /// Name: properties
            /// Description: A list of properties for an uploaded video, for example, the length of the video
            /// Permissions: Requires access_token
            /// Return: array of objects containing the name and text
            /// </summary>
            [DataMember(Name = "properties")]
            public object[] Properties { get; set; }

            /// <summary>
            /// Name: icon
            /// Description: A link to an icon representing the type of this post
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "icon")]
            public string Icon { get; set; }

            /// <summary>
            /// Name: actions
            /// Description: A list of available actions on the post (including commenting, liking, and an optional app-specified action)
            /// Permissions: Requires access_token
            /// Return: array of objects containing the name and link
            /// </summary>
            [DataMember(Name = "actions")]
            public object[] Actions { get; set; }

            /// <summary>
            /// Name: privacy
            /// Description: The privacy settings of the Post
            /// Permissions: read_stream
            /// Return: A JSON object with fields described here
            /// </summary>
            [DataMember(Name = "privacy")]
            public object Privacy { get; set; }

            /// <summary>
            /// Name: type
            /// Description: A string indicating the type for this post (including link, photo, video)
            /// Permissions: Requires access_token
            /// Return: string
            /// </summary>
            [DataMember(Name = "type")]
            public string Type { get; set; }

            /// <summary>
            /// Name: likes
            /// Description: Likes for this post
            /// Permissions: Requires access_token
            /// Return: Structure containing a data object and the count of total likes, with data containing an array of objects, each with the name and Facebook id of the user who liked the post
            /// </summary>
            [DataMember(Name = "likes")]
            public object Likes { get; set; }

            /// <summary>
            /// Name: place
            /// Description: Location associated with a Post, if any
            /// Permissions: read_stream
            /// Return: object containing id and name of Page associated with this location, and a location field containing geographic information such as latitude, longitude, country, and other fields (fields will vary based on geography and availability of information)
            /// </summary>
            [DataMember(Name = "place")]
            public GraphAPI.Venue Place { get; set; }

            /// <summary>
            /// Name: story
            /// Description: Text of stories not intentionally generated by users, such as those generated when two users become friends; you must have the "Include recent activity stories" migration enabled in your app to retrieve these stories
            /// Permissions: read_stream
            /// Return: string
            /// </summary>
            [DataMember(Name = "story")]
            public string Story { get; set; }

            /// <summary>
            /// Name: story_tags
            /// Description: Objects (Users, Pages, etc) tagged in a non-intentional story; you must have the "Include recent activity stories" migration enabled in your app to retrieve these tags
            /// Permissions: read_stream
            /// Return: object containing fields whose names are the indexes to where objects are mentioned in the message field; each field in turn is an array containing an object with id, name, offset, and length fields, where length is the length, within the message field, of the object mentioned
            /// </summary>
            [DataMember(Name = "story_tags")]
            public object StoryTags { get; set; }

            /// <summary>
            /// Name: with_tags
            /// Description: Objects (Users, Pages, etc) tagged as being with the publisher of the post ("Who are you with?" on Facebook)
            /// Permissions: read_stream
            /// Return: objects containing id and name fields, encapsulated in a data[] array
            /// </summary>
            [DataMember(Name = "with_tags")]
            public object[] WithTags { get; set; }

            /// <summary>
            /// Name: comments
            /// Description: Comments for this post
            /// Permissions: read_stream
            /// Return: Structure containing a data object containing an array of objects, each with the id, from, message, and created_time for each comment
            /// </summary>
            [DataMember(Name = "comments")]
            public object Comments { get; set; }

            /// <summary>
            /// Name: object_id
            /// Description: The Facebook object id for an uploaded photo or video
            /// Permissions: read_stream
            /// Return: number
            /// </summary>
            [DataMember(Name = "object_id")]
            public double? ObjectID { get; set; }

            /// <summary>
            /// Name: application
            /// Description: Information about the application this post came from
            /// Permissions: read_stream
            /// Return: object containing the name and id of the application
            /// </summary>
            [DataMember(Name = "application")]
            public GraphAPI.Domain Application { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: The time the post was initially published
            /// Permissions: read_stream
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: The time of the last comment on this post
            /// Permissions: read_stream
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: include_hidden
            /// Description: Whether to include posts that have been set to Hidden from Timeline
            /// Permissions: read_stream
            /// Return: boolean
            /// </summary>
            [DataMember(Name = "include_hidden")]
            public bool? IncludeHidden { get; set; }
        }
    }
}
