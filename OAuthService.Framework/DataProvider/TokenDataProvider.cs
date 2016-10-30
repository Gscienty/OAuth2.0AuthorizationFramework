using System;
using System.Collections.Generic;
using OAuthService.Framework.Entities;

using MongoDB.Driver;

namespace OAuthService.Framework.DataProvider
{
    internal class TokenDataProvider : AbstractDataProvider
    {
        #region Property
        internal static TokenDataProvider Instance { get; private set; }

        protected override string CollectionName { get; } = "TokenCollection";
        #endregion

        #region Construction
        private TokenDataProvider() : base(
            DataProviderConfiguration.Instance.ConnectionString,
            DataProviderConfiguration.Instance.DatabaseName
        ) { }

        internal static void Initialize() { Instance = new TokenDataProvider(); }
        #endregion

        #region Method
        internal void Insert(OAuthTokenEntity entity)
        {
            this.GetCollection<OAuthTokenEntity>().InsertOne(entity);
        }

        internal OAuthTokenEntity GetTokenEntity(string token)
        {
            return this.GetCollection<OAuthTokenEntity>().FindSync(
                Builders<OAuthTokenEntity>.Filter
                    .Eq(entity => entity.AccessToken, token)
            ).FirstOrDefault();
        }
        #endregion
    }
}