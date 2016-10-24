using MongoDB.Bson.Serialization.Attributes;

namespace OAuthService.Framework.Entities
{
    [BsonDiscriminatorAttribute("scope")]
    internal sealed class ScopeEntity
    {
        [BsonElementAttribute("scope_name")]
        internal string ScopeName { get; set; }

        [BsonElementAttribute("scope_lock")]
        internal bool IsLock{ get; set; }
    }
}