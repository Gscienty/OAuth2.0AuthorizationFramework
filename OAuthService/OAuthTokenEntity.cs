namespace OAuthService
{
    public sealed class OAuthTokenEntity
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
        public string Scope { get; set; }
        public string State { get; set; }
    }
}