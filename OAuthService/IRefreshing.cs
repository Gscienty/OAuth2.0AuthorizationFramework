using OAuthService.Entities;

namespace OAuthService
{
    ///<summary>
    ///刷新令牌
    ///</summary>
    public interface IRefreshing
    {
        ///<summary>
        ///获取新的令牌
        ///<param name="refreshToken">刷新令牌</param>
        ///<param name="scope">声明</param>
        ///<returns>返回授权</returns>
        ///</summary>
        OAuthTokenEntity AuthorizationRequest(
            string refreshToken,
            string scope
        );
    }
}