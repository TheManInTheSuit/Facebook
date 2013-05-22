using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class Insights
        {
            /// <summary>
            /// Name: id
            /// Description: ID of the insight
            /// Permissions: generic access_token or read_insights
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: name
            /// Description: Name of the metric
            /// Permissions: generic access_token or read_insights
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: period
            /// Description: Length of the period during which the insights were collected
            /// Permissions: generic access_token or read_insights
            /// Return: string
            /// </summary>
            [DataMember(Name = "period")]
            public string Period { get; set; }

            /// <summary>
            /// Name: values
            /// Description: Individual data points for the insight
            /// Permissions: generic access_token or read_insights
            /// Return: array of objects containing value and end_time
            /// </summary>
            [DataMember(Name = "values")]
            public Values[] Values { get; set; }

            /// <summary>
            /// Name: description
            /// Description: The full description of the metric
            /// Permissions: generic access_token or read_insights
            /// Return: string
            /// </summary>
            [DataMember(Name = "description")]
            public string Description { get; set; }
        }
    }
}