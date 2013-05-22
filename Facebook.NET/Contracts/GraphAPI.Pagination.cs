using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed partial class Pagination
        {
            [DataMember(Name = "cursors")]
            public GraphApi.Pagination.Cursor Cursors { get; set; }

            [DataMember(Name = "next")]
            public string Previous { get; set; }

            [DataMember(Name = "next")]
            public string Next { get; set; }
        }
    }
}