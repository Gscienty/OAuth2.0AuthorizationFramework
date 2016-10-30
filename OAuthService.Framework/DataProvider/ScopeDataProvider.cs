using System.Collections.Generic;
using OAuthService.Framework.Entities;
using MongoDB.Driver;

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
        internal IDictionary<string, ScopeEntity> GetScopes()
        {
            ICollection<ScopeEntity> collection = this.GetCollection<ScopeEntity>().FindSync(
                Builders<ScopeEntity>.Filter
                .Eq(entity => entity.IsLock, false)
            ).ToList();
            
            Dictionary<string, ScopeEntity> result = new Dictionary<string, ScopeEntity>();
            foreach(ScopeEntity item in collection)
            {
                result[item.ScopeName] = item;
            }
            return result;
        }
        #endregion
    }
}