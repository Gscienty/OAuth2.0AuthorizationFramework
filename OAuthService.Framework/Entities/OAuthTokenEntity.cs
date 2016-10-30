using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OAuthService.Framework.Entities
{
    [BsonDiscriminatorAttribute("token")]
    public sealed class OAuthTokenEntity
    {
        [BsonIdAttribute]
        internal ObjectId ID { get; set; }

        [BsonElementAttribute("access_token")]
        public string AccessToken { get; set; }

        [BsonElementAttribute("token_type")]
        public string TokenType { get; set; }

        [BsonElementAttribute("expires_in")]
        public int ExpiresIn { get; set; }

        [BsonElementAttribute("refresh_token")]
        public string RefreshToken { get; set; }

        [BsonElementAttribute("scopes")]
        internal ICollection<string> Scopes { get; set; }

        [BsonElementAttribute("start_time")]
        internal Int64 StartTime { get; set; } 
    }
}