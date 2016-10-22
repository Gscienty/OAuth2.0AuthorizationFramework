using System.Collections.Generic;
using System;

namespace OAuthService
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
        ///<param name="scope">授权范围</param>
        ///<returns>返回授权码及声明</returns>
        ///</summary>
        Tuple<String, String> AuthorizationRequest(
            String clientID,
            String state,
            IEnumerable<String> scope
        );

        ///<summary>
        ///获取令牌
        ///<param name="clientID">客户端凭证</param>
        ///<param name="code">授权码</param>
        ///</summary>
        Token AccessTokenRequest(
            string clientID,
            string code
        );
    }
}