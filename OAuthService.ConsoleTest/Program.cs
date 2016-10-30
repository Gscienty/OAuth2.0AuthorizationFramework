using System;
using System.Collections.Generic;
using OAuthService.Framework.Service;
using OAuthService.Framework.DataProvider;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataProviderConfiguration.Initialize("mongodb://localhost:27017", "OAuthService");

            List<string> scopes = new List<string>();
            scopes.Add("library");
            scopes.Add("card");
            AuthorizationCode service = new AuthorizationCode();
            Console.WriteLine(
                service.VerifyScopes(scopes)
            );
        }
    }
}
