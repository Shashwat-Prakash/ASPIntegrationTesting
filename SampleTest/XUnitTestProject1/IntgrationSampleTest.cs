/*using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using SampleTest;
using SampleTest.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class IntgrationSampleTest
    {
        public readonly HttpClient testClient;
        public readonly TestServer _server;
        public IntgrationSampleTest()
        {
            //var appFactory = new WebApplicationFactory<Startup>();
            _server = new TestServer(new WebHostBuilder()
                        .UseStartup<Startup>());
            testClient = _server.CreateClient();

            //using MySqlConnection connection = new MySqlConnection("");
        }
    }
}
*/