using System;

namespace OAuthService.Exceptions
{
    public abstract class OAuthServiceAbstractException : Exception
    {
        #region Property
        public abstract string ErrorType { get; }

        public virtual string ErrorDescription { get; }

        public virtual string ErrorURI { get; }
        #endregion

        #region Construction
        public OAuthServiceAbstractException() { }

        public OAuthServiceAbstractException(string message) : base(message) { }
        #endregion
    }
}