using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace OAuthService.Framework.Entities
{
    [BsonDiscriminatorAttribute("code")]
    public sealed class OAuthCodeEntity
    {
        #region Property
        [BsonElementAttribute("code")]
        public string Code { get; set; }

        [BsonElementAttribute("client_id")]
        public string ClientID { get; set; }

        [BsonElementAttribute("timeout")]
        public Int64 TimeoutTimestamp { get; set; }
        
        [BsonElementAttribute("scopes")]
        public ICollection<string> Scopes { get; set; }
        #endregion
    }
}