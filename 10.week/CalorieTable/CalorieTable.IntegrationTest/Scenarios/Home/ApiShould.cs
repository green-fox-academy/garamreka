using CalorieTable.Entities;
using CalorieTable.IntegrationTest.TestFixture;
using CalorieTable.Models;
using CalorieTable.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CalorieTable.IntegrationTest
{
    [Collection("BaseCollection")]
    public class ApiShould
    {
        private TestContext Context;

        public ApiShould(TestContext context)
        {
            this.Context = context;
        }

        [Fact]
        public async Task AddNewFood()
        {
            //arrange
            var options = new DbContextOptionsBuilder<FoodContext>().UseInMemoryDatabase(databaseName: "FoodTestDb").Options;

            using (var dbContext = new FoodContext(options))
            {
                var quoteRepository = new FoodRepository(dbContext);

                //act
                dbContext.Foods.Add(new Food()
                {
                    Name = "Orange",
                    Amount = 1,
                    Calorie = 120
                });
                dbContext.SaveChanges();

                //assert
                string expected = "Orange";
                var quote = await dbContext.Foods.FirstOrDefaultAsync(f => f.Name.Equals("Orange"));
                Assert.Equal(expected, quote.Name);

            }
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            //act
            var response = await Context.Client.GetAsync("/api");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnContent()
        {
            //act
            var response = await Context.Client.GetAsync("/api");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.NotNull(responseJson);
        }
    }
}
