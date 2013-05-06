using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed class Job
        {
            [DataMember(Name = "employer")]
            public GraphAPI.Domain Employer { get; set; }

            [DataMember(Name = "position")]
            public GraphAPI.Domain Position { get; set; }

            [DataMember(Name = "description")]
            public string Description { get; set; }

            [DataMember(Name = "start_date")]
            public string StartDate { get; set; }

            [DataMember(Name = "end_date")]
            public string EndDate { get; set; }
        }
    }
}
