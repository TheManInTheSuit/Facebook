using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Comment : GraphApi.MessageObject
        {
            /// <summary>
            /// Name: like_count
            /// Description: The number of times this comment was liked
            /// Permissions: generic access_token
            /// Return: integer
            /// </summary>
            [DataMember(Name = "like_count")]
            public int? LikeCount { get; set; }

            /// <summary>
            /// Name: user_likes
            /// Description: This field is returned only if the authenticated user likes this comment
            /// Permissions: generic access_token
            /// Return: string; always true
            /// </summary>
            [DataMember(Name = "user_likes")]
            public string UserLikes { get; set; }

            /// <summary>
            /// Name: parent
            /// Description: If this comment is a reply, this field returns the parent comment, otherwise no value
            /// Permissions: generic access_token
            /// Return: reference
            /// </summary>
            [DataMember(Name = "parent")]
            public MessageObject Parent { get; set; }

            /// <summary>
            /// Name: can_comment
            /// Description: Specifies whether you can reply to this comment
            /// Permissions: generic access_token
            /// Return: boolean
            /// </summary>
            [DataMember(Name = "can_comment")]
            public bool? CanComment { get; set; }

            /// <summary>
            /// Name: comment_count
            /// Description: The number of replies to this comment, if any
            /// Permissions: generic access_token
            /// Return: integer
            /// </summary>
            [DataMember(Name = "comment_count")]
            public int? CommentCount { get; set; }
        }
    }
}