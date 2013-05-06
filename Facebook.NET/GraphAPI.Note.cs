using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Note : MessageObject
        {
            /// <summary>
            /// Name: subject
            /// Description: The title of the note
            /// Permissions: generic access_token or user_notes or friends_notes
            /// Return: string
            /// </summary>
            [DataMember(Name = "subject")]
            public string Subject { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: The time the note was last updated
            /// Permissions: generic access_token or user_notes or friends_notes
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: icon
            /// Description: The icon that Facebook displays with notes
            /// Permissions: generic access_token or user_notes or friends_notes
            /// Return: string containing a valid URL
            /// </summary>
            [DataMember(Name = "icon")]
            public string Icon { get; set; }
        }
    }
}
