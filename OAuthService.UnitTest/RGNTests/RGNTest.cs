using Xunit;
using OAuthService.Framework.Utilities;

namespace OAuthService.Tests.RGNTests
{
    public class RGNTests
    {
        [Fact]
        public void TestName()
        {
            for(int i = 0; i < 10; i++)
            {
                Assert.True(RandomGenerator.GeneratorRandomVSCode().Contains("~"));
            }
        }
    }
}