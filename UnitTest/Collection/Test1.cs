using Microsoft.AspNetCore.Mvc.Testing;
using TestApp;
using Xunit;

namespace UnitTest.Collection
{
    [Collection("test collection")]
    public class Test1
    {
        private WebApplicationFactory<Startup> _factory;

        public Test1(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }
    }
}