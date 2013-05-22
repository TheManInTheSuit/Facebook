using System;
using System.IO;
using System.Linq;

namespace Facebook
{
    public static partial class GraphApi
    {
        public sealed partial class Me : Api
        {
            internal Me(string accessToken) : base(accessToken)
            {
            }
                
            public GraphApi.User Get(params string[] fields)
            {
                string formattedUri = GraphApi.GetFormattedUri(
                    MeUri,
                    GraphApi.GetParameterizedString("fields", fields),
                    GraphApi.GetParameterizedString("access_token", base.AccessToken));

                GraphApi.User result = GraphApi.DeserializeResponse<GraphApi.User>(formattedUri);

                return result;
            }

            /// <summary>
            /// Name: accounts
            /// Description: The Facebook apps and pages owned by the current user.
            /// Permissions: manage_pages yields access_tokens that can be used to query the Graph API on behalf of the app/page
            /// Returns: array of objects containing account name, access_token, category, id
            /// </summary>
            /// <returns></returns>
            public GraphApi.Account Accounts(int limit, params string[] fields)
            {
                string formattedUri = GraphApi.GetFormattedUri(
                    Path.Combine(MeUri, "accounts"),
                    GraphApi.GetParameterizedString("access_token", base.AccessToken),
                    GraphApi.GetParameterizedString("limit", limit.ToString()),
                    GraphApi.GetParameterizedString("fields", fields));

                GraphApi.Account result = GraphApi.DeserializeResponse<GraphApi.Account>(formattedUri);

                return result;
            }

            /// <summary>
            /// Name: accounts
            /// Description: The Facebook apps and pages owned by the current user.
            /// Permissions: manage_pages yields access_tokens that can be used to query the Graph API on behalf of the app/page
            /// Returns: array of objects containing account name, access_token, category, id
            /// </summary>
            /// <returns></returns>
            public GraphApi.Account Accounts(params string[] fields)
            {
                string formattedUri = GraphApi.GetFormattedUri(
                    Path.Combine(MeUri, "accounts"),
                    GraphApi.GetParameterizedString("access_token", base.AccessToken),
                    GraphApi.GetParameterizedString("fields", fields));

                GraphApi.Account result = GraphApi.DeserializeResponse<GraphApi.Account>(formattedUri);

                return result;
            }
        }
    }
}