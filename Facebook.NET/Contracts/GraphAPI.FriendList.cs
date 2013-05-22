using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class FriendList
        {
            /// <summary>
            /// Name: id
            /// Description: The friend list ID
            /// Permissions: read_friendlists
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The name of the friend list
            /// Permissions: read_friendlists
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: list_type
            /// Description: The type of the friends list; Possible values are: close_friends, acquaintances, restricted,user_created, education, work, current_city or family
            /// Permissions: read_friendlists
            /// Return: string
            /// </summary>
            [DataMember(Name = "list_type")]
            public string ListType { get; set; }
        }
    }
}