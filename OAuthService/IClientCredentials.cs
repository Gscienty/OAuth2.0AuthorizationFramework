namespace OAuthService
{
    ///<summary>
    ///客户端凭证认证方式
    ///</summary>
    public interface IClientCredentials
    {
        ///<summary>
        ///授权请求
        ///<param name="scope">声明</param>
        ///<returns>令牌</returns>
        ///</summary>
        OAuthTokenEntity AuthorizationRequest(
            string scope
        );
    }
}