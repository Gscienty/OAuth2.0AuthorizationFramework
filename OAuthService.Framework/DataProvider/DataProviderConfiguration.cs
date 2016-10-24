using MongoDB.Bson.Serialization;
using OAuthService.Framework.Entities;

namespace OAuthService.Framework.DataProvider
{
    public sealed class DataProviderConfiguration
    {
        #region Property
        public static DataProviderConfiguration Instance { get; private set; }
        public string ConnectionString { get; private set; }
        public string DatabaseName { get; private set; } 
        #endregion

        #region Construction
        private DataProviderConfiguration(string connectionString, string databaseName)
        {
            this.ConnectionString = connectionString;
            this.DatabaseName = databaseName;
        }

        public static void Initialize(string connectionString, string databaseName)
        {
            DataProviderConfiguration.Instance = new DataProviderConfiguration(connectionString, databaseName);
        }
        #endregion
    }
}