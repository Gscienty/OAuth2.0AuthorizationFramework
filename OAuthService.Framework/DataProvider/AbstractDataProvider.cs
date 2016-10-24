using MongoDB.Driver;
namespace OAuthService.Framework.DataProvider
{
    public abstract class AbstractDataProvider
    {
        #region Field
        private IMongoDatabase _database;
        #endregion

        #region Property
        protected abstract string CollectionName { get; }
        #endregion

        #region Construction
        internal AbstractDataProvider(string connectionString, string databaseName)
        {
            this._database = new MongoClient(connectionString).GetDatabase(databaseName);
        }
        #endregion

        #region Method
        protected IMongoCollection<T> GetCollection<T>()
        {
            return this._database.GetCollection<T>(this.CollectionName);
        }
        #endregion
    }
}