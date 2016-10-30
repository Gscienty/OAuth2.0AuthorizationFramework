using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace OAuthService.Framework.Entities
{
    [BsonDiscriminatorAttribute("client_metadata")]
    internal sealed class ClientEntity
    {
        [BsonIdAttribute]
        internal ObjectId ID { get; set; }

        [BsonElementAttribute("client_id")]
        public string ClientID { get; set; }

        [BsonElementAttribute("realname")]
        public string ClientName { get; set; }

        [BsonElementAttribute("lifecycle")]
        public int ExpiresIn { get; set; }

        [BsonElementAttribute("limit_scopes")]
        public SortedSet<string> Scopes { get; set; }

        [BsonElementAttribute("enable")]
        public bool IsEnable { get; set; }

        [BsonElementAttribute("author")]
        public string Author { get; set; }
    }
}