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
    }
}