namespace OAuthService.Exceptions
{
    public sealed class UnAuthorizedClientException : OAuthServiceAbstractException
    {
        #region Property
        public override string ErrorType { get; } = "unauthorized_client";
        public override string ErrorDescription { get; } = "the client is not authorized to request an authorization code using this method";
        #endregion

        #region Construction
        public UnAuthorizedClientException() { }
        public UnAuthorizedClientException(string message) : base(message) { }
        #endregion
    }
}