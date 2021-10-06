using System.Data;
using Xunit;

namespace Bluebird.Tests
{
    public class ExampleTests
    {
        [Fact]
        public void ExampleTest()
        {
            using var connProvider = new SqliteConnectionProvider();
            Assert.Equal(ConnectionState.Open, connProvider.Connection.State);
        }
    }
}