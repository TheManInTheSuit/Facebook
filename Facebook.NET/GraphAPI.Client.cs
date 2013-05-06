using System;
using System.IO;

namespace Facebook
{
    public static partial class GraphAPI
    {
                    
        public sealed partial class Client : API
        {
            private GraphAPI.User user = null;
            private GraphAPI.User User
            {
                get { return user ?? (user = Me.Get()); }
            }

            private Me me = null;
            public Me Me
            {
                get { return me ?? (me = new Me(base.AccessToken)); }
            }

            public Client(string accessToken)
                : base(accessToken)
            {
            }

            public T Get<T>(string id, params string[] fields)
            {
                string formattedUri = GraphAPI.GetFormattedUri(
                    Path.Combine(graphUri, id),
                    GraphAPI.GetParameterizedString("fields", fields),
                    GraphAPI.GetParameterizedString("access_token", base.AccessToken));

                T result = GraphAPI.DeserializeResponse<T>(formattedUri);

                return result;
            }

            public GraphAPI.Event CreateEvent(string name, string startTime,
                string endTime = null, string description = null, string location = null,
                    string locationID = null, string privacyType = null)
            {
                string formattedUri = GraphAPI.GetFormattedUri(
                    Path.Combine(graphUri, User.ID, "events"),
                    ParameterizeIfNotNull("name", name),
                    ParameterizeIfNotNull("start_time", startTime),
                    ParameterizeIfNotNull("end_time", endTime),
                    ParameterizeIfNotNull("description", description),
                    ParameterizeIfNotNull("location", location),
                    ParameterizeIfNotNull("location_id", locationID),
                    ParameterizeIfNotNull("privacy_type", privacyType),
                    ParameterizeIfNotNull("access_token", base.AccessToken));

                GraphAPI.Response<GraphAPI.Event> result = GraphAPI.DeserializeResponse<GraphAPI.Response<GraphAPI.Event>>(formattedUri);

                GraphAPI.Event resultData = result.Data;
                resultData.Name = name;
                resultData.StartTime = startTime;
                resultData.EndTime = endTime;
                resultData.Description = description;
                //resultData.Location = new string
                resultData.Privacy = privacyType;

                return resultData;
            }

            public string ParameterizeIfNotNull(string name, string value)
            {
                return string.IsNullOrEmpty(value) ?
                    string.Empty : GraphAPI.GetParameterizedString(name, value);
            }
        }
    }
}