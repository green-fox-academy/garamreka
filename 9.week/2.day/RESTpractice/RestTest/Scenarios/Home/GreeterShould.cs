using RestTest.TestFixtures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RestTest.Scenarios
{
    [Collection("BaseCollection")]
    public class GreeterShould
    {
        private TestContext Context;

        public GreeterShould(TestContext context)
        {
            //arrange
            Context = context;
        }
    }
}
