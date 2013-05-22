using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class QuestionObject
        {
            /// <summary>
            /// Name: id
            /// Description: Question ID
            /// Permissions: user_questions or friends_questions
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: from
            /// Description: User who asked the question
            /// Permissions: user_questions or friends_questions
            /// Return: Object containing id and name fields
            /// </summary>
            [DataMember(Name = "from")]
            public GraphApi.Domain From { get; set; }

            /// <summary>
            /// Name: question
            /// Description: Text of the question
            /// Permissions: user_questions or friends_questions
            /// Return: string
            /// </summary>
            [DataMember(Name = "question")]
            public string Question { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: Time when question was created
            /// Permissions: user_questions or friends_questions
            /// Return: string containing ISO-8601 datetime
            /// </summary>
            [DataMember(Name = "created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: Time when question was last updated
            /// Permissions: user_questions or friends_questions
            /// Return: string containing ISO-8601 datetime
            /// </summary>
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: options
            /// Description: The list of options available as answers to the question
            /// Permissions: user_questions or friends_questions
            /// Return: Object containing data[] array of options, as described in the options connection below
            /// </summary>
            [DataMember(Name = "options")]
            public object[] Options { get; set; }
        }
    }
}