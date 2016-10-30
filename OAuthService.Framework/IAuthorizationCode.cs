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
        OAuthErrorType VerifyClient(string clientID);

        ///<summary>
        ///验证权限合法性
        ///<param name="scopes">权限集合</param>
        ///<returns>权限是否合法</returns>
        ///</summary>
        OAuthErrorType VerifyScopes(ICollection<string> scopes);

        ///<summary>
        ///获取Access Token
        ///<param name="clientID">ClientID</param>
        ///<returns>Access Token</returns>
        ///</summary>
        string GetCode(string clientID, ICollection<string> scopes);

        OAuthAccessToken GetAccessToken(string clientID, string code); 
    }
}