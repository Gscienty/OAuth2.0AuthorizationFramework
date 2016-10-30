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
            IEnumerable<string> scopes
        )
        {
            //获取客户端元数据
            ClientEntity clientEntity = ClientInformationDataProvider.Instance.GetClientMetadata(clientID);
            //判断客户端是否存在，是否被锁定
            if(clientEntity == null || clientEntity.IsEnable == false) { throw new UnAuthorizedClientException(); }
            //判断权限是否合法
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