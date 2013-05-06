using System;
using System.Linq;
using System.IO;

namespace Facebook
{
	public static partial class GraphAPI
	{
        public sealed partial class Me : API
        {
            internal Me(string accessToken)
                : base(accessToken)
            {
            }
                
            public GraphAPI.User Get(params string[] fields)
            {
                string formattedUri = GraphAPI.GetFormattedUri(
                    meUri,
                    GraphAPI.GetParameterizedString("fields", fields),
                    GraphAPI.GetParameterizedString("access_token", base.AccessToken));

                GraphAPI.User result = GraphAPI.DeserializeResponse<GraphAPI.User>(formattedUri);

                return result;
            }

            /// <summary>
            /// Name: accounts
            /// Description: The Facebook apps and pages owned by the current user.
            /// Permissions: manage_pages yields access_tokens that can be used to query the Graph API on behalf of the app/page
            /// Returns: array of objects containing account name, access_token, category, id
            /// </summary>
            /// <returns></returns>
            public GraphAPI.Account Accounts(int limit, params string[] fields)
            {
                string formattedUri = GraphAPI.GetFormattedUri(
                    Path.Combine(meUri, "accounts"),
                    GraphAPI.GetParameterizedString("access_token", base.AccessToken),
                    GraphAPI.GetParameterizedString("limit", limit.ToString()),
                    GraphAPI.GetParameterizedString("fields", fields));

                GraphAPI.Account result = GraphAPI.DeserializeResponse<GraphAPI.Account>(formattedUri);

                return result;
            }

            /// <summary>
            /// Name: accounts
            /// Description: The Facebook apps and pages owned by the current user.
            /// Permissions: manage_pages yields access_tokens that can be used to query the Graph API on behalf of the app/page
            /// Returns: array of objects containing account name, access_token, category, id
            /// </summary>
            /// <returns></returns>
            public GraphAPI.Account Accounts(params string[] fields)
            {
                string formattedUri = GraphAPI.GetFormattedUri(
                    Path.Combine(meUri, "accounts"),
                    GraphAPI.GetParameterizedString("access_token", base.AccessToken),
                    GraphAPI.GetParameterizedString("fields", fields));

                GraphAPI.Account result = GraphAPI.DeserializeResponse<GraphAPI.Account>(formattedUri);

                return result;
            }
        }
	}
}
