using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OAuthService.Framework.Entities
{
    [BsonDiscriminatorAttribute("scope")]
    public sealed class ScopeEntity
    {
        [BsonIdAttribute]
        internal ObjectId ID { get; set; }
        
        [BsonElementAttribute("scope_name")]
        public string ScopeName { get; set; }

        [BsonElementAttribute("scope_logicalname")]
        public string ScopeLogicalName { get; set; }

        [BsonElementAttribute("scope_lock")]
        internal bool IsLock{ get; set; }
    }
}