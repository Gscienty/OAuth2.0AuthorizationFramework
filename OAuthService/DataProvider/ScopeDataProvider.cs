using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthService.Entities;
using MongoDB.Driver;
using OAuthService.Exceptions;

namespace OAuthService.DataProvider
{
    internal class ScopeDataProvider : AbstractDataProvider
    {
        #region Property
        protected override string CollectionName { get; } = "ScopeCollection";
        #endregion

        #region Construction
        internal ScopeDataProvider() : base (
            DataProviderConfiguration.Instance.ConnectionString, 
            DataProviderConfiguration.Instance.DatabaseName
        ) { }
        #endregion

        #region Method
        internal IEnumerable<string> GetScopes(IEnumerable<string> scopes)
        {
            foreach(string scope in scopes)
            {
                if(this.GetCollection<ScopeEntity>().CountAsync(Builders<ScopeEntity>.Filter.Eq(entity => entity.ScopeName, scope)).Result != 0){
                    yield return scope;
                }
                else { throw new InvalidScopeException(); }
            }
        }
        #endregion
    }
}