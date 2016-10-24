using System;

namespace OAuthService.Framework.Exceptions
{
    public abstract class AbstractOAuthServiceException : Exception
    {
        #region Property
        public abstract string ErrorType { get; }

        public virtual string ErrorDescription { get; }

        public virtual string ErrorURI { get; }
        #endregion

        #region Construction
        public AbstractOAuthServiceException() { }

        public AbstractOAuthServiceException(string message) : base(message) { }
        #endregion
    }
}