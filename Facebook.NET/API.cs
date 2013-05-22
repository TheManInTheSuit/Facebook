using System;

namespace Facebook
{
    public class Api
    {
        public Api(string accessToken)
        {
            this.AccessToken = accessToken;
        }

        protected string AccessToken { get; private set; }
    }
}