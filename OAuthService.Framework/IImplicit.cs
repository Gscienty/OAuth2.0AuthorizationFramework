using System.Collections.Generic;
using OAuthService.Framework.Entities;

namespace OAuthService.Framework
{
    ///<summary>
    ///简明模式
    ///</summary>
    public interface IImplicit
    {
        ///<summary>
        ///获取令牌
        ///<param name="clientID">客户端凭证</param>
        ///<param name="state">声明</param>
        ///<param name="scope">授权范围</param>
        ///<returns>返回授权</returns>
        ///</summary>
        OAuthTokenEntity AuthorizationRequest(
            string clientID,
            string state,
            IEnumerable<string> scope
        );
    }
}