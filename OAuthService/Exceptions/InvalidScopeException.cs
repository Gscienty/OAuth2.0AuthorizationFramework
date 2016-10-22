namespace OAuthService.Exceptions
{
    public sealed class InvalidScopeException : AbstractOAuthServiceException
    {
        #region Property
        public override string ErrorType { get; } = "invalid_scope";

        public override string ErrorDescription { get; } = "the requested scope is invalid, unknow, or malformed";
        #endregion

        #region Construction
        public InvalidScopeException() { }

        public InvalidScopeException(string message) : base(message) { }
        #endregion
    }
}