using System;
using System.Collections.Generic;
using OAuthService.Framework;
using OAuthService.Framework.Entities;
using OAuthService.Framework.Exceptions;
using OAuthService.Framework.DataProvider;

namespace OAuthService.Framework.Service
{
    internal class AuthorizationCode : IAuthorizationCode
    {
        public string AuthorizationRequest(
            string clientID,
            string state,
            IEnumerable<string> scopes
        )
        {
            ClientEntity clientEntity = ClientInformationDataProvider.Instance.GetClientMetadata(clientID);
            if(clientEntity == null) { throw new UnAuthorizedClientException(); }
            IEnumerable<string> legalScopes = ScopeDataProvider.Instance.GetScopes(scopes);
            foreach(string scope in legalScopes) { if(clientEntity.Scopes.Contains(scope) == false) { throw new InvalidScopeException(); } }
            
            return null;
        }

        public OAuthTokenEntity AccessTokenRequest(
            string clientID,
            string code
        )
        {
            return null;
        }
    }
}