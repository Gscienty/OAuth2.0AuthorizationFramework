using System;
using OAuthService.Framework.Utilities;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RandomGenerator.GeneratorRandomVSCode(256));
        }
    }
}
