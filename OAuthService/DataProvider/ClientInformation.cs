namespace OAuthService.DataProvider
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
        
        #endregion
    }
}