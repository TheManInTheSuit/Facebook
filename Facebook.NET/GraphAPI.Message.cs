using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public class MessageObject
        {
            /// <summary>
            /// Name: id
            /// Description: The unique ID for this message
            /// Permissions: read_mailbox
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: A timestamp of when this message was created
            /// Permissions: read_mailbox
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: from
            /// Description: 
            /// Permissions: read_mailbox
            /// Return: Object containing name and Facebook id (if available)
            /// </summary>
            [DataMember(Name = "from")]
            public GraphAPI.Domain From { get; set; }

            /// <summary>
            /// Name: to
            /// Description: A list of the message recipients
            /// Permissions: read_mailbox
            /// Return: Array of objects each containing name and Facebook id (if available)
            /// </summary>
            [DataMember(Name = "to")]
            public GraphAPI.Domain[] To { get; set; }

            /// <summary>
            /// Name: message
            /// Description: The text of the message
            /// Permissions: read_mailbox
            /// Return: string
            /// </summary>
            [DataMember(Name = "message")]
            public string Message { get; set; }
        }
    }
}
