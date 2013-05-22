using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class AccountData : GraphApi.IObject
        {
            [DataMember(Name = "id")]
            public string ID { get; set; }

            [DataMember(Name = "name")]
            public string Name { get; set; }
            
            [DataMember(Name = "category")]
            public string Category { get; set; }
            
            [DataMember(Name = "access_token")]
            public string AccessToken { get; set; }
            
            [DataMember(Name = "perms")]
            public string[] Permissions { get; set; }
        }
    }
}