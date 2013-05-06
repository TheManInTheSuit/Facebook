using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facebook;

namespace TestProject
{
    [TestClass]
    public class FacebookGraphAPITests
    {
        //private readonly string appID = "200087070129759";
        //private readonly string appSecret = "195ed17914ce1c2e2c554c27e4a9c735";
        //private readonly string localhost = "http://localhost:65363";

        /// <summary>
        /// Use this uri to generate an access token and copy/paste the value into the "accessToken" variable.
        /// </summary>
        //private readonly string apiExplorer = "https://developers.facebook.com/tools/explorer";
        private readonly string accessToken = "BAACEdEose0cBAK6TRaHZA9kZCNfYGkj97IeZBVNAHAk5P3tCCgbZCz9qTcAPUAqZA2REcOAhh9jtHov9H7X1TmPs8lDOCnsvva5k9JPPkEXSIrjRqtIgQi7EpgbBLe4bFFJgqSOxBpotIGbvA7kaIMsLPZASlltaqRnVd6TaoYhMbucVe0XAVcQMaFsTx99CGohBoNVi9wCeY8XTiOZBsBcu7qoJ4Vv9VDXppnUPiSpfwZDZD";
        private readonly string userID = "100000891257073";

        [TestMethod]
        public void GetUserTest()
        {
            var client = new GraphAPI.Client(accessToken);
            GraphAPI.User user = client.Get<GraphAPI.User>(userID);

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.ID);
            Assert.IsNotNull(user.Name);
        }

        [TestMethod]
        public void GetUserWithFilterTest()
        {
            var client = new GraphAPI.Client(accessToken);
            GraphAPI.User user = client.Get<GraphAPI.User>(userID, GraphAPI.User.Fields.ID);

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.ID);
            Assert.IsNull(user.Name);
        }

        [TestMethod]
        public void MeGetTest()
        {
            var client = new GraphAPI.Client(accessToken);
            GraphAPI.User user = client.Me.Get();

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.ID);
            Assert.IsNotNull(user.Name);
        }

        [TestMethod]
        public void MeGetWithFilterTest()
        {
            var client = new GraphAPI.Client(accessToken);
            GraphAPI.User user = client.Me.Get(GraphAPI.User.Fields.ID);

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.ID);
            Assert.IsNull(user.Name);
        }

        [TestMethod]
        public void MeAccountsGetTest()
        {
            var client = new GraphAPI.Client(accessToken);
            GraphAPI.Account account = client.Me.Accounts(10, GraphAPI.User.Fields.ID);

            Assert.IsNotNull(account);
            Assert.IsNotNull(account.Paging);
            Assert.IsNotNull(account.Data);

            var result = account.Data.FirstOrDefault();
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ID);
        }

        [TestMethod]
        public void EventsPostTest()
        {
            var client = new GraphAPI.Client(accessToken);
            GraphAPI.Event result = client.CreateEvent(Guid.NewGuid().ToString(), DateTime.UtcNow.ToString());

            Assert.IsNotNull(result);

            bool hasValue = String.IsNullOrEmpty(result.ID);
            Assert.IsFalse(hasValue);
            Assert.AreEqual(result.ID, userID);
        }
        
    }
}
