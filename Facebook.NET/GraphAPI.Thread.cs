using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Thread
        {
            /// <summary>
            /// Name: id
            /// Description: The unique ID for this message thread
            /// Permissions: read_mailbox
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: snippet
            /// Description: Fragment of the thread for use in thread lists
            /// Permissions: read_mailbox
            /// Return: string
            /// </summary>
            [DataMember(Name = "snippet")]
            public string Snippet { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: Timestamp of when the thread was last updated
            /// Permissions: read_mailbox
            /// Return: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: message_count
            /// Description: Number of messages in the thread
            /// Permissions: read_mailbox
            /// Return: integer
            /// </summary>
            [DataMember(Name = "message_count")]
            public int? MessageCount { get; set; }

            /// <summary>
            /// Name: unread_count
            /// Description: Number of unread messages in the thread
            /// Permissions: read_mailbox
            /// Return: integer
            /// </summary>
            [DataMember(Name = "unread_count")]
            public int? UnreadCount { get; set; }

            /// <summary>
            /// Name: tags
            /// Description: Thread tags
            /// Permissions: read_mailbox
            /// Return: array of objects containing name
            /// </summary>
            [DataMember(Name = "tags")]
            public object[] Tags { get; set; }

            /// <summary>
            /// Name: participants
            /// Description: List of the thread participants
            /// Permissions: read_mailbox
            /// Return: array of objects each containing name, email, and Facebook id (if available)
            /// </summary>
            [DataMember(Name = "participants")]
            public object[] Participants { get; set; }

            /// <summary>
            /// Name: former_participants
            /// Description: List of former thread participants who have unsubscribed from the thread
            /// Permissions: read_mailbox
            /// Return: array of objects each containing name, email, and Facebook id (if available)
            /// </summary>
            [DataMember(Name = "former_participants")]
            public object[] FormerParticipants { get; set; }

            /// <summary>
            /// Name: senders
            /// Description: List of participants who have sent a message in the thread
            /// Permissions: read_mailbox
            /// Return: array of objects each containing name, email, and Facebook id (if available)
            /// </summary>
            [DataMember(Name = "senders")]
            public object[] Senders { get; set; }

            /// <summary>
            /// Name: messages
            /// Description: List of the message objects contained in this thread
            /// Permissions: read_mailbox
            /// Return: array of message objects
            /// </summary>
            [DataMember(Name = "messages")]
            public GraphAPI.MessageObject[] Messages { get; set; }
        }
    }
}
