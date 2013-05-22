using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facebook;

namespace TestProject
{
    [TestClass]
    public class FacebookGraphApiTests
    {
        //private readonly string localhost = "http://localhost:65363";

        /// <summary>
        /// Use this uri to generate an access token and copy/paste the value into the "accessToken" variable.
        /// uri: "https://developers.facebook.com/tools/explorer"
        /// </summary>
        private readonly string accessToken = "CAACEdEose0cBAHZAyi4nZC3dgXohu8VvZCeIF0L3FvoSZBZAdmI335QQZAmEjGFoe2dZBL6rmYXlStOAI6BhsEKV3wRZAMBlSqJtth6yMrBdlzR5DAOxb3rnQIrOG715ybpFzNJCed1rxcTVKd5FLc8wu76UveCZAnmlfusnXk8KT2QZDZD";
        private readonly string userID = "100000891257073";

        [TestMethod]
        public void GetUserTest()
        {
            var client = new GraphApi.Client(accessToken);
            GraphApi.User user = client.Get<GraphApi.User>(userID);

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.ID);
            Assert.IsNotNull(user.Name);
        }

        [TestMethod]
        public void GetUserWithFilterTest()
        {
            var client = new GraphApi.Client(accessToken);
            GraphApi.User user = client.Get<GraphApi.User>(userID, GraphApi.User.Fields.ID);

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.ID);
            Assert.IsNull(user.Name);
        }

        [TestMethod]
        public void MeGetTest()
        {
            var client = new GraphApi.Client(accessToken);
            GraphApi.User user = client.Me.Get();

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.ID);
            Assert.IsNotNull(user.Name);
        }

        [TestMethod]
        public void MeGetWithFilterTest()
        {
            var client = new GraphApi.Client(accessToken);
            GraphApi.User user = client.Me.Get(GraphApi.User.Fields.ID);

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.ID);
            Assert.IsNull(user.Name);
        }

        [TestMethod]
        public void MeAccountsGetTest()
        {
            var client = new GraphApi.Client(accessToken);
            GraphApi.Account account = client.Me.Accounts(10, GraphApi.User.Fields.ID);

            Assert.IsNotNull(account);
            Assert.IsNotNull(account.Data);
        }

        [TestMethod]
        public void EventsPostTest()
        {
            var client = new GraphApi.Client(accessToken);
            string dateTime = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd THH:mm:ss-");
            string offset = DateTimeOffset.Now.ToString("HHmm");

            GraphApi.Event result = client.CreateEvent("test event", dateTime + offset);

            Assert.IsNotNull(result);

            bool isIDEmpty = String.IsNullOrEmpty(result.ID);
            Assert.IsFalse(isIDEmpty);
        }
        
    }
}
