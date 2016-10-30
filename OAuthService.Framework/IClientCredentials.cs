using OAuthService.Framework.Entities;

namespace OAuthService.Framework
{
    ///<summary>
    ///客户端凭证认证方式
    ///</summary>
    public interface IClientCredentials
    {
        ///<summary>
        ///授权请求
        ///<returns>令牌</returns>
        ///</summary>
        OAuthTokenEntity AuthorizationRequest();
    }
}