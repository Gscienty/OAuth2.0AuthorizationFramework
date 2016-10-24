using System;
using Xunit;
using System.Collections.Generic;
using OAuthService.Framework.DataProvider;

namespace OAuthService.Tests.ScopeTests
{
    public class ScopeTests
    {
        [Fact]
        public void GetScopesTest()
        {
            DataProviderConfiguration.Initialize("mongodb://localhost:27017", "OAuthService");
            ScopeDataProvider provider = new ScopeDataProvider();
            List<string> scopes = new List<string>();
            scopes.Add("test");
            
            try
            {
                IEnumerable<string> legcalScopes = provider.GetScopes(scopes);
            }
            catch(OAuthService.Framework.Exceptions.AbstractOAuthServiceException ex)
            {
                Assert.True(ex is OAuthService.Framework.Exceptions.InvalidScopeException);
            }
            
        }
    }
}