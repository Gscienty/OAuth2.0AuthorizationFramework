using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace OAuthService.Framework.Entities
{
    [BsonDiscriminatorAttribute("client_metadata")]
    internal sealed class ClientEntity
    {
        [BsonElementAttribute("client_id")]
        public string ClientID { get; set; }

        [BsonElementAttribute("realname")]
        public string ClientName { get; set; }

        [BsonElementAttribute("lifecycle")]
        public string ExpiresIn { get; set; }

        [BsonElementAttribute("limit_scopes")]
        public SortedSet<string> Scopes { get; set; }
    }
}