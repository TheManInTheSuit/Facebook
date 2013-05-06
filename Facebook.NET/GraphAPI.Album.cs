using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Album
        {
            /// <summary>
            /// Name: id
            /// Description: The album ID
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The profile that created this album
            /// Permissions: Any valid access_token
            /// Return: object containing id and name fields
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The title of the album
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: description
            /// Description: The description of the album
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string
            /// </summary>            
            [DataMember(Name = "description")]
            public string Description { get; set; }

            /// <summary>
            /// Name: location
            /// Description: The location of the album
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "location")]
            public string Location { get; set; }

            /// <summary>
            /// Name: link
            /// Description: A link to this album on Facebook
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "link")]
            public string Link { get; set; }

            /// <summary>
            /// Name: cover_photo
            /// Description: The album cover photo ID
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "cover_photo")]
            public string CoverPhoto { get; set; }

            /// <summary>
            /// Name: privacy
            /// Description: The privacy settings for the album
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "privacy")]
            public string Privacy { get; set; }

            /// <summary>
            /// Name: count
            /// Description: The number of photos in this album
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "count")]
            public string Count { get; set; }

            /// <summary>
            /// Name: type
            /// Description: The type of the album: profile, mobile, wall, normal or album
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "type")]
            public string Type { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: The time the photo album was initially created
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: The last time the photo album was updated
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: can_upload
            /// Description: Determines whether the UID can upload to the album and returns true if the user owns the album, the album is not full, and the app can add photos to the album
            /// Permissions: Any valid access_token or user_photos or friend_photos
            /// Return: boolean
            /// </summary>
            [DataMember(Name = "can_upload")]
            public bool? CanUpload { get; set; }
        }
    }
}