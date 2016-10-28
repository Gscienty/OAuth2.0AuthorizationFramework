using OAuthService.Framework.Entities;
using MongoDB.Driver;

namespace OAuthService.Framework.DataProvider
{
    internal class ClientInformationDataProvider : AbstractDataProvider
    {
        #region Property
        internal static ClientInformationDataProvider Instance { get; private set; }
        protected override string CollectionName { get; } = "ClientInformationCollection";
        #endregion

        #region Construction
        private ClientInformationDataProvider() : base(
            DataProviderConfiguration.Instance.ConnectionString,
            DataProviderConfiguration.Instance.DatabaseName
        ) { }
        
        internal static void Initialize() { Instance = new ClientInformationDataProvider(); }
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