using System;
using System.IO;

namespace Facebook
{
    public static partial class GraphApi
    {
        public sealed partial class Client : Api
        {
            private GraphApi.User user = null;
            private Me me = null;

            public Client(string accessToken) : base(accessToken)
            {
            }

            public Me Me
            {
                get
                {
                    return this.me ?? (this.me = new Me(base.AccessToken));
                }
            }

            private GraphApi.User User
            {
                get
                {
                    return this.user ?? (this.user = this.Me.Get());
                }
            }

            public T Get<T>(string id, params string[] fields)
            {
                string formattedUri = GraphApi.GetFormattedUri(
                    Path.Combine(GraphUri, id),
                    GraphApi.GetParameterizedString("fields", fields),
                    GraphApi.GetParameterizedString("access_token", base.AccessToken));

                T result = GraphApi.DeserializeResponse<T>(formattedUri);

                return result;
            }

            public GraphApi.Event CreateEvent(string name, string startTime,
                string endTime = null, string description = null, string location = null,
                string locationID = null, string privacyType = null)
            {
                string formattedUri = GraphApi.GetFormattedUri(
                    Path.Combine(GraphUri, this.User.ID, "events"),
                    this.ParameterizeIfNotNull("name", name),
                    this.ParameterizeIfNotNull("start_time", startTime),
                    this.ParameterizeIfNotNull("end_time", endTime),
                    this.ParameterizeIfNotNull("description", description),
                    this.ParameterizeIfNotNull("location", location),
                    this.ParameterizeIfNotNull("location_id", locationID),
                    this.ParameterizeIfNotNull("privacy_type", privacyType),
                    this.ParameterizeIfNotNull("access_token", base.AccessToken));

                GraphApi.Event result = GraphApi.DeserializeResponse<GraphApi.Event>(formattedUri, "POST");
                result.Name = name;
                result.StartTime = startTime;
                result.EndTime = endTime;
                result.Description = description;
                result.Location = location;
                result.Privacy = privacyType;
                
                return result;
            }

            public string ParameterizeIfNotNull(string name, string value)
            {
                return string.IsNullOrEmpty(value) ? string.Empty : GraphApi.GetParameterizedString(name, value);
            }
        }
    }
}