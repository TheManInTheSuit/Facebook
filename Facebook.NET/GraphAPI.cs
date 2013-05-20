using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;

namespace Facebook
{
    public static partial class GraphAPI
    {
        private const string oAuthCodeUri = "https://www.facebook.com/dialog/oauth";
        private const string accessTokenUri = "https://graph.facebook.com/oauth/access_token";
        private const string meUri = "https://graph.facebook.com/me";
        private const string graphUri = "https://graph.facebook.com/";
        
        private static readonly Guid uniqueID = Guid.NewGuid();

        public static string GetAccessTokenUri(string appID, string appSecret, string authCode, string redirectUri)
        {
            return string.Format(
                string.Format("{0}?client_id={0}&redirect_uri={1}&client_secret={2}&code={3}", accessTokenUri),
                appID, redirectUri, appSecret, authCode);
        }

        public static string GetOAuthCodeUri(string appID, string redirectUri)
        {
            string uri = string.Format(
                string.Format("{0}?client_id={0}&redirect_uri={1}&state={2}", oAuthCodeUri),
                appID, redirectUri, uniqueID);
            return uri;
        }
        internal static string GetParameterizedString(string name, params string[] values)
        {
            bool isNullOrEmpty = values == null || values.Count() == 0;

            return isNullOrEmpty == false ?
                string.Format("{0}={1}", name, values.Aggregate(
                    (previous, current) => string.Format("{0},{1}", previous, current)
                )) : null;
        }

        internal static string GetFormattedUri(string uriBase, params string[] parameters)
        {
            UriBuilder builder = new UriBuilder(uriBase);
            if (parameters != null)
            {
                builder.Query = string.Format("{0}", parameters.Aggregate(
                    (previous, current) => 
                        string.IsNullOrEmpty(previous) ? current :
                        string.IsNullOrEmpty(current) ? previous :
                        string.Format("{0}&{1}", previous, current)
                        ));
            }
            return builder.ToString();
        }

        internal static T DeserializeResponse<T>(string uri, string method = "GET")
        {
            T result;
            WebRequest request = HttpWebRequest.Create(uri);
            request.Method = method;
            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                    result = (T)serializer.ReadObject(stream);
                    stream.Close();
                }
                response.Close();
            }

            return result;
        }
    }
}