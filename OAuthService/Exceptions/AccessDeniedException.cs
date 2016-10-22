namespace OAuthService.Exceptions
{
    public sealed class AccessDeniedException : AbstractOAuthServiceException
    {
        #region Property
        public override string ErrorType { get; } = "access_denied";

        public override string ErrorDescription { get; } = "the resource owner or authorization server denied the request";
        #endregion

        #region Construction
        public AccessDeniedException() { }
        public AccessDeniedException(string message) : base(message) { }
        #endregion
    }
}