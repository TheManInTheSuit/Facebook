using System;

namespace Facebook
{
    public class API
    {
        private readonly string accessToken;
        protected string AccessToken { get { return accessToken; } }

        public API(string accessToken)
        {
            this.accessToken = accessToken;
        }
    }
}
