using System;
using System.Collections.Generic;
using OAuthService.Framework.Service;
using OAuthService.Framework.DataProvider;
using OAuthService.Framework.Entities;

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
            scopes.Add("invaild");
            AuthorizationCode service = new AuthorizationCode();
            Console.WriteLine(
                service.VerifyScopes(scopes)
            );

            IEnumerable<ScopeEntity> scopeEntities = service.GetScopes(scopes);

            foreach(var item in scopeEntities)
            {
                Console.WriteLine("name:{0} Logical:{1}", item.ScopeName, item.ScopeLogicalName);
            }

            Console.WriteLine(service.VerifyClient("123asd2345sdfgsdfg3546t34eeas"));
        }
    }
}
