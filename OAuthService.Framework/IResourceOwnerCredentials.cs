using System;
using OAuthService.Framework.Entities;

namespace OAuthService.Framework
{
    ///<summary>
    ///资源所有者凭证模式
    ///</summary>
    public interface IResourceOwnerCredentials
    {
        ///<summary>
        ///授权请求
        ///<param name="authorizationCredential">凭证认证</param>
        ///<param name="scope">声明</param>
        ///<returns>令牌</returns>
        ///</summary>
        OAuthTokenEntity AuthorizationRequest(
            Func<bool> authorizationCredential,
            string scope
        );
    }
}