using System;
using OAuthService.Framework.Entities;
using OAuthService.Framework.Utilities;
using MongoDB.Driver;

namespace OAuthService.Framework.DataProvider
{
    internal class AccessCodeDataProvider : AbstractDataProvider
    {
        #region Property
        internal static AccessCodeDataProvider Instance { get; private set; }
        protected override string CollectionName { get; } = "AccessCodeCollection";
        #endregion

        #region Construction
        private AccessCodeDataProvider() : base(
            DataProviderConfiguration.Instance.ConnectionString,
            DataProviderConfiguration.Instance.DatabaseName
        ){ }

        internal static void Initialize() { Instance = new AccessCodeDataProvider(); }
        #endregion

        #region Method
        internal void Insert(OAuthCodeEntity entity)
        {
            this.GetCollection<OAuthCodeEntity>().InsertOne(entity);
        }

        internal OAuthCodeEntity Get(string code)
        {
            return this.GetCollection<OAuthCodeEntity>().FindOneAndDelete(
                Builders<OAuthCodeEntity>.Filter
                    .Eq(entity => entity.Code, code)
            );
        }
        #endregion
    }
}