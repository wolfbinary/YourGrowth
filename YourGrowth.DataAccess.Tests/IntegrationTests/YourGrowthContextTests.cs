using Microsoft.VisualStudio.TestTools.UnitTesting;
using YourGrowth.DataAccess.Contexts;

namespace YourGrowth.DataAccess.Tests
{
    [TestClass]
    public class YourGrowthContextTests
    {
        [TestMethod]
        public void TestDatabaseConnectionWorks()
        {
            var dbContext = new YourGrowthContext();

            
        }
    }
}
