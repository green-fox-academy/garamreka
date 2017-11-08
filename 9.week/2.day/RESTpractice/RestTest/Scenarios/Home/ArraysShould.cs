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
    public class ArraysShould
    {
        private TestContext Context;

        public ArraysShould(TestContext context)
        {
            //arrange
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            //act
            var response = await Context.Client.GetAsync("/arrays/sum");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnErrorWithoutWhat()
        {
            //act
            var arrayProperties = new Properties
            {
                Numbers = new int[] { 1, 2, 5, 10 }
            };
            var content = new StringContent(
                JsonConvert.SerializeObject(arrayProperties).ToString(),
                encoding: Encoding.UTF8,
                mediaType: "application/json");
            var response = await Context.Client.PostAsync("/arrays", content);
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"Please provide what to do with the numbers!\"}", responseString);
        }

        [Fact]
        public async Task ReturnErrorWithoutNumbers()
        {
            //act
            var arrayProperties = new Properties
            {
                What = "sum"
            };
            var content = new StringContent(
                JsonConvert.SerializeObject(arrayProperties).ToString(),
                encoding: Encoding.UTF8,
                mediaType: "application/json");
            var response = await Context.Client.PostAsync("/arrays", content);
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"Please provide what to do with the numbers!\"}", responseString);
        }

        [Fact]
        public async Task ReturnSum()
        {
            //act
            var arrayProperties = new Properties
            {
                What = "sum",
                Numbers = new int[] { 1, 2, 5, 10 }
            };
            var content = new StringContent(
                JsonConvert.SerializeObject(arrayProperties).ToString(),
                encoding: Encoding.UTF8,
                mediaType: "application/json");
            var response = await Context.Client.PostAsync("/arrays", content);
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"result\":\"18\"}", responseString);
        }

        [Fact]
        public async Task ReturnMultiply()
        {
            //act
            var arrayProperties = new Properties
            {
                What = "multiply",
                Numbers = new int[] { 1, 2, 5, 10 }
            };
            var content = new StringContent(
                JsonConvert.SerializeObject(arrayProperties).ToString(),
                encoding: Encoding.UTF8,
                mediaType: "application/json");
            var response = await Context.Client.PostAsync("/arrays", content);
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"result\":\"100\"}", responseString);
        }

        [Fact]
        public async Task ReturnDouble()
        {
            //act
            var arrayProperties = new Properties
            {
                What = "double",
                Numbers = new int[] { 1, 2, 5, 10 }
            };
            var content = new StringContent(
                JsonConvert.SerializeObject(arrayProperties).ToString(),
                encoding: Encoding.UTF8,
                mediaType: "application/json");
            var response = await Context.Client.PostAsync("/arrays", content);
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"result\":[2,4,10,20]}", responseString);
        }
    }
}
