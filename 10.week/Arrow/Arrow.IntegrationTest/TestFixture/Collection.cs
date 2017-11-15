using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrow.IntegrationTest.TestFixture
{
    [CollectionDefinition("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>

    {
    }
}
