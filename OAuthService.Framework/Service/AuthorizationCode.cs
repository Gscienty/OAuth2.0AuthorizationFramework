using System;
using System.Collections.Generic;
using OAuthService.Framework;
using OAuthService.Framework.Entities;
using OAuthService.Framework.DataProvider;

namespace OAuthService.Framework.Service
{
    internal class AuthorizationCode : IAuthorizationCode
    {
        public OAuthErrorType VerifyClient(string clientID)
        {
            ClientEntity entity = ClientInformationDataProvider.Instance.GetClientMetadata(clientID);
            if(entity == null) { return OAuthErrorType.InvalidClientID; }
            else if(entity.IsEnable == false) { return OAuthErrorType.AccessDeniend; }
            return OAuthErrorType.NoError;
        }

        public OAuthErrorType VerifyScopes(IEnumerable<string> scopes)
        {
            IDictionary<string, ScopeEntity> legcalScopes = ScopeDataProvider.Instance.GetScopes();

            foreach(string scope in scopes)
            {
                if(legcalScopeNames.Contains(scope) == false) { return OAuthErrorType.InvalidScope; }
            }
            return OAuthErrorType.NoError;
        }

        public IEnumerable<ScopeEntity> GetScopes(IEnumerable<string> scopes)
        {
            IDictionary<string, ScopeEntity> legcalScopes = ScopeDataProvider.Instance.GetScopes();
            foreach(string scope in scopes)
            {
                yield return legcalScopes[scope];
            }
        }

        public string GetCode(string clientID, ICollection<string> scopes)
        {

        }
    }
}