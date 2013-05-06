using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Photo
        {
            /// <summary>
            /// Name: id
            /// Description: The photo ID
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: The profile (user or page) that posted this photo
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: object containing id and name fields
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: tags
            /// Description: The tagged users and their positions in this photo
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: array of objects, the x and y coordinates are percentages from the left and top edges of the photo, respectively
            /// </summary>
            [DataMember(Name = "tags")]
            public object[] Tags { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The user provided caption given to this photo - do not include advertising in this field
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: name_tags
            /// Description: An array containing an array of objects mentioned in the name field which contain the id, name, and type of each object as well as the offset and length which can be used to match it up with its corresponding string in the name field
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: array
            /// </summary>
            [DataMember(Name = "name_tags")]
            public object[][] NameTags { get; set; }

            /// <summary>
            /// Name: icon
            /// Description: The icon that Facebook displays when photos are published to the Feed
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: string representing a valid URL
            /// </summary>
            [DataMember(Name = "icon")]
            public string Icon { get; set; }

            /// <summary>
            /// Name: picture
            /// Description: The thumbnail-sized source of the photo
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: string representing a valid URL
            /// </summary>
            [DataMember(Name = "picture")]
            public string Picture { get; set; }

            /// <summary>
            /// Name: source
            /// Description: The source image of the photo - currently this can have a maximum width or height of 720px, increasing to 960px on 1st March 2012
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: string representing a valid URL
            /// </summary>
            [DataMember(Name = "source")]
            public string Source { get; set; }

            /// <summary>
            /// Name: height
            /// Description: The height of the photo in pixels
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: number
            /// </summary>
            [DataMember(Name = "height")]
            public double? Height { get; set; }

            /// <summary>
            /// Name: width
            /// Description: The width of the photo in pixels
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: number
            /// </summary>
            [DataMember(Name = "width")]
            public double? Width { get; set; }

            /// <summary>
            /// Name: images
            /// Description: The 4 different stored representations of the photo
            /// Permissions: Requires access_token
            /// Return: array of objects, containing height, width, and source fields
            /// </summary>
            [DataMember(Name = "images")]
            public object[] Images { get; set; }

            /// <summary>
            /// Name: link
            /// Description: A link to the photo on Facebook
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: string representing a valid URL
            /// </summary>
            [DataMember(Name = "link")]
            public string Link { get; set; }

            /// <summary>
            /// Name: place 
            /// Description: Location associated with a Photo, if any
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: object containing id and name of Page associated with this location, and a location field containing geographic information such as latitude, longitude, country, and other fields (fields will vary based on geography and availability of information)
            /// </summary>
            [DataMember(Name = "place")]
            public GraphAPI.Venue Place { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: The time the photo was initially published
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: The last time the photo or its caption was updated
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: position
            /// Description: The position of this photo in the album
            /// Permissions: generic access_token or user_photos or friends_photos
            /// Return: number
            /// </summary>
            [DataMember(Name = "position")]
            public double? Position { get; set; }
        }
    }
}
