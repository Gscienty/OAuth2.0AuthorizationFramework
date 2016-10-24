namespace OAuthService.Framework.Exceptions
{
    public sealed class TemporarilyUnavailableException : AbstractOAuthServiceException
    {
        #region Property
        public override string ErrorType { get; } = "temporarily_unavailable";
        public override string ErrorDescription { get; } = "the authorization server is currently unable to handle the request due to a temporary overloading or maintenance of the server.";
        #endregion

        #region Construction
        public TemporarilyUnavailableException() { }
        public TemporarilyUnavailableException(string message) : base(message) { }
        #endregion
    }
}