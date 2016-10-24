using MongoDB.Bson.Serialization.Attributes;

namespace OAuthService.Framework.Entities
{
    [BsonDiscriminatorAttribute("scope")]
    internal sealed class ScopeEntity
    {
        [BsonElementAttribute("name")]
        internal string ScopeName { get; set; }

        [BsonElementAttribute("lock")]
        internal bool IsLock{ get; set; }
    }
}