using OAuthService.Framework.Entities;
using MongoDB.Driver;

namespace OAuthService.Framework.DataProvider
{
    internal class ClientInformation : AbstractDataProvider
    {
        #region Property
        protected override string CollectionName { get; } = "ClientInformationCollection";
        #endregion

        #region Construction
        internal ClientInformation() : base(
            DataProviderConfiguration.Instance.ConnectionString,
            DataProviderConfiguration.Instance.DatabaseName
        ) { }
        #endregion

        #region Method
        internal ClientEntity GetClientMetadata(string clientID)
        {
            return this.GetCollection<ClientEntity>().FindSync(
                        Builders<ClientEntity>.Filter
                            .Eq(e => e.ClientID, clientID)
                    ).SingleOrDefault();
        }
        #endregion
    }
}