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
        ///验证客户端合法性
        ///<param name="clientID">ClientID</param>
        ///<param name="scopes">客户端权限</param>
        ///<returns>客户端是否合法，若不合法产生的是何种错误</returns>
        ///</summary>
        Tuple<bool, OAuthErrorEntity> VerifyClient(string clientID, IEnumerable<string> scopes);

        ///<summary>
        ///获取Access Token
        ///<param name="clientID">ClientID</param>
        ///<returns>Access Token</returns>
        ///</summary>
        OAuthAccessToken GetAccessToken(string clientID);
    }
}