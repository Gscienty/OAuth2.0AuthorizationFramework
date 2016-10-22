namespace OAuthService.Exceptions
{
    public sealed class UnsupportedResponseTypeException : AbstractOAuthServiceException
    {
        #region Property
        public override string ErrorType { get; } = "unsupported_response_type";
        public override string ErrorDescription { get; } = "the authorization server dose not support obtaining an authorization code using this method";
        #endregion

        #region Construction
        public UnsupportedResponseTypeException() { }

        public UnsupportedResponseTypeException(string message) : base(message) { }
        #endregion
    }
}