namespace OAuthService.Framework.Entities
{
    public sealed class OAuthAccessToken
    {
        #region Property
        public string Code { get; set; }
        public string ClientId { get; set; }
        
        #endregion
    }
}