using System.Collections.Generic;
namespace OAuthService
{
    public interface IImplicit
    {
        ///<summary>
        ///获取令牌
        ///<param name="clientID">客户端凭证</param>
        ///<param name="state">声明</param>
        ///<param name="scope">授权范围</param>
        ///</summary>
        Token AuthorizationRequest(
            string clientID,
            string state,
            IEnumerable<string> scope
        );
    }
}