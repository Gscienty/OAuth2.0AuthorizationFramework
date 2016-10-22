namespace OAuthService.Exceptions
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
    }
}