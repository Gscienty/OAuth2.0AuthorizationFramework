using System;
using System.Collections.Generic;
namespace OAuthService.Framework.Entities
{
    public sealed class OAuthAccessToken
    {
        #region Property
        public string Code { get; set; }
        public string ClientId { get; set; }
        public Int64 TimeoutTimestamp { get; set; }
        public ICollection<string> Scopes { get; set; }
        #endregion
    }
}