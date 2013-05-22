using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Job
        {
            [DataMember(Name = "employer")]
            public GraphApi.Domain Employer { get; set; }

            [DataMember(Name = "position")]
            public GraphApi.Domain Position { get; set; }

            [DataMember(Name = "description")]
            public string Description { get; set; }

            [DataMember(Name = "start_date")]
            public string StartDate { get; set; }

            [DataMember(Name = "end_date")]
            public string EndDate { get; set; }
        }
    }
}