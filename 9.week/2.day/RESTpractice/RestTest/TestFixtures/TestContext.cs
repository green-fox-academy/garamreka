using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RESTpractice;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RestTest.TestFixtures
{
    public class TestContext
    {
        public HttpClient Client { get; set; }
        private readonly TestServer Server;

        public TestContext()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }
    }
}
