namespace OAuthService.Framework.Exceptions
{
    public sealed class InvalidRequestException : AbstractOAuthServiceException
    {
        #region Property
        public override string ErrorType { get; } = "invalid_request";

        public override string ErrorDescription { get; } = "the request is missing a required parameter.";
        #endregion

        #region Construction
        public InvalidRequestException() { }
        public InvalidRequestException(string message) : base(message) { }
        #endregion
    }
}