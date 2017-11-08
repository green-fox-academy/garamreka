using Newtonsoft.Json;
using RESTpractice.Models;
using RestTest.TestFixtures;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Rest.IntegrationTests.Scenarios.Home
{
    [Collection("BaseCollection")]
    public class DountilShould
    {
        private TestContext Context;

        public DountilShould(TestContext context)
        {
            //arrange
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            //act
            var response = await Context.Client.GetAsync("/dountil/sum");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnErrorWithoutWhat()
        {
            //act
            var usedUntil = new Properties
            {
                Until = 5,
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(usedUntil).ToString(),
                encoding: Encoding.UTF8,
                mediaType: "application/json");
            var response = await Context.Client.PostAsync("/dountil", content);

            //assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task ReturnErrorWithoutNumber()
        {
            //act
            var content = new StringContent(
                content: "",
                encoding: Encoding.UTF8, 
                mediaType: "application/json");
            var response = await Context.Client.PostAsync("/dountil/sum", content);
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"Please provide a number!\"}", responseString);
        }
    }
}
