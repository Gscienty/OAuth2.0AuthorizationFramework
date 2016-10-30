using System;
using System.Collections.Generic;
using OAuthService.Framework;
using OAuthService.Framework.Entities;
using OAuthService.Framework.DataProvider;
using OAuthService.Framework.Utilities;

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
                if(legcalScopes.ContainsKey(scope) == false) { return OAuthErrorType.InvalidScope; }
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
            OAuthCodeEntity entity = new OAuthCodeEntity()
            {
                Code = RandomGenerator.GeneratorRandomNQCode(32),
                ClientID = clientID,
                TimeoutTimestamp = ConvertTimespan.Get(DateTime.Now.AddMinutes(10)),
                Scopes = scopes
            };
            AccessCodeDataProvider.Instance.Insert(entity);
            return entity.Code;
        }

        public OAuthAccessToken GetAccessToken(string clientID, string code)
        {

        }
    }
}