using Microsoft.AspNetCore.Mvc.Testing;
using TestApp;
using Xunit;

namespace UnitTest.Collection
{
    [Collection("test collection")]
    public class Test2
    {
        private WebApplicationFactory<Startup> _factory;

        public Test2(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }
    }
}