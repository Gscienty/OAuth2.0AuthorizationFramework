using System.Collections.Generic;
using System;
using OAuthService.Framework.Entities;

namespace OAuthService.Framework
{
    ///<summary>
    ///授权码模式
    ///</summary>
    public interface IAuthorizationCode
    {
        ///<summary>
        ///授权请求
        ///<param name="clientID">客户端凭证</param>
        ///<param name="state">声明</param>
        ///<param name="scopes">授权范围</param>
        ///<returns>返回授权码及声明</returns>
        ///</summary>
        string AuthorizationRequest(
            string clientID,
            string state,
            IEnumerable<string> scopes
        );

        ///<summary>
        ///获取令牌
        ///<param name="clientID">客户端凭证</param>
        ///<param name="code">授权码</param>
        ///</summary>
        OAuthTokenEntity AccessTokenRequest(
            string clientID,
            string code
        );
    }
}