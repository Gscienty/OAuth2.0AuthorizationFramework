using OAuthService.Exceptions;
namespace OAuthService.Entities
{
    public sealed class OAuthErrorEntity
    {
        #region Property
        public string ErrorType { get; private set; }
        public string ErrorDescription { get; private set; }
        public string ErrorURI { get; set; }
        public string State { get; set; }
        #endregion

        #region Construction
        public OAuthErrorEntity(AbstractOAuthServiceException exception)
        {
            this.ErrorType = exception.ErrorType;
            this.ErrorDescription = exception.ErrorDescription;
        }
        #endregion

        #region Provider
        public static OAuthErrorEntity AccessDenied { get; } = new OAuthErrorEntity(new AccessDeniedException());
        public static OAuthErrorEntity InvalidRequest { get; } = new OAuthErrorEntity(new InvalidRequestException());
        public static OAuthErrorEntity InvalidScope { get; } = new OAuthErrorEntity(new InvalidScopeException());
        public static OAuthErrorEntity ServerError { get; } = new OAuthErrorEntity(new ServerErrorException());
        public static OAuthErrorEntity TemporarilyUnavaliable { get; } = new OAuthErrorEntity(new TemporarilyUnavailableException());
        public static OAuthErrorEntity UnAuthorizedClient { get; } = new OAuthErrorEntity(new UnAuthorizedClientException());
        public static OAuthErrorEntity UnsupportedResponseType { get; } = new OAuthErrorEntity(new UnsupportedResponseTypeException());
        #endregion
    }
}