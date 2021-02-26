using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using SampleTest;
using SampleTest.Controller;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class ValueControllerTest : IClassFixture<WebApplicationFactory<SampleTest.Startup>>
    {
        private readonly HttpClient testClient;
        private readonly TestServer _server;
        private readonly WebApplicationFactory<SampleTest.Startup> _fixture;
        public ValueControllerTest(WebApplicationFactory<SampleTest.Startup> fixture)
        {       
            //var appFactory = new WebApplicationFactory<Startup>();
            _server = new TestServer(new WebHostBuilder()
                        .UseStartup<Startup>());
            //testClient = _server.CreateClient();
            _fixture = fixture;
            _fixture.ClientOptions.BaseAddress = new Uri("http://localhost:5000");
            _fixture.ClientOptions.AllowAutoRedirect = true;

            
            //using MySqlConnection connection = new MySqlConnection("");
            
        }


        [Theory]
        [InlineData("/api/Values")]
        /*[InlineData("/Index")]
        [InlineData("/About")]
        [InlineData("/Privacy")]
        [InlineData("/Contact")]*/
        public async Task GetAll_Fail_ReturnsEmptyBody(string url)
        {
            // Arrange
            var client = _fixture.CreateClient();

            // Act
            var response = await client.GetAsync(url);            

            // Assert
            //response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);            
        }

        [Theory]
        [InlineData("/api/Values/2")]
        public async Task GetAll_Pass_ReturnsValidBody(string url)
        {
            // Arrange
            var client = _fixture.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            //response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            
        }
    }
}

