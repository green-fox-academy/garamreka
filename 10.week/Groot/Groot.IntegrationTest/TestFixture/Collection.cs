using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Groot.IntegrationTest.TestFixture
{
    [CollectionDefinition("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
    }
}
