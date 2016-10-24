using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthService.Framework.Entities;
using MongoDB.Driver;
using OAuthService.Framework.Exceptions;

namespace OAuthService.Framework.DataProvider
{
    public class ScopeDataProvider : AbstractDataProvider
    {
        #region Property
        protected override string CollectionName { get; } = "ScopeCollection";
        #endregion

        #region Construction
        public ScopeDataProvider() : base (
            DataProviderConfiguration.Instance.ConnectionString, 
            DataProviderConfiguration.Instance.DatabaseName
        ) { }
        #endregion

        #region Method
        public IEnumerable<string> GetScopes(IEnumerable<string> scopes)
        {
            foreach(string scope in scopes)
            {
                ScopeEntity legalScope = this.GetCollection<ScopeEntity>().FindSync(
                                                Builders<ScopeEntity>.Filter
                                                    .Eq(entity => entity.ScopeName, scope)).SingleOrDefault();
                                                    
                if(legalScope != null && legalScope.IsLock == false)
                {
                    yield return scope;
                }
                else { throw new InvalidScopeException(); }
            }
        }
        #endregion
    }
}