using System.Collections.Generic;
using OAuthService.Framework.Entities;
using MongoDB.Driver;
using OAuthService.Framework.Exceptions;

namespace OAuthService.Framework.DataProvider
{
    internal class ScopeDataProvider : AbstractDataProvider
    {
        #region Property
        internal static ScopeDataProvider Instance { get; private set; }
        protected override string CollectionName { get; } = "ScopeCollection";
        #endregion

        #region Construction
        private ScopeDataProvider() : base (
            DataProviderConfiguration.Instance.ConnectionString, 
            DataProviderConfiguration.Instance.DatabaseName
        ) { }

        internal static void Initialize() { Instance = new ScopeDataProvider(); }
        #endregion

        #region Method
        internal IEnumerable<string> GetScopes(IEnumerable<string> scopes)
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