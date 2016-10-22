namespace OAuthService.Exceptions
{
    public sealed class ServerErrorException : AbstractOAuthServiceException
    {
        #region Property
        public override string ErrorType { get; } = "server_error";
        public override string ErrorDescription { get; } = "the authorization server encountered an unexpected condition that prevented it from fulfilling the request"; 
        #endregion

        #region Construction
        public ServerErrorException() { }
        public ServerErrorException(string message) : base(message) { }
        #endregion
    }
}