using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        public sealed partial class Pagination
        {
            [DataContract]
            public sealed class Cursor
            {
                [DataMember(Name = "after")]
                public string After { get; set; }
                
                [DataMember(Name = "before")]
                public string Before { get; set; }
            }
        }
    }
}
