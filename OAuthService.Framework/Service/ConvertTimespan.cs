using System;
namespace OAuthService.Framework.Utilities
{
    internal static class ConvertTimespan
    {
        private static DateTime startDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        internal static Int64 Get(DateTime time)
        {
            return (Int64)(time - startDateTime).TotalSeconds;
        }
    }
}