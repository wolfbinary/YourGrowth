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
            using (var dbContext = new YourGrowthContext())
            {

                var result = dbContext.Muscles.Find(1);

                Assert.IsNotNull(result);
            }
        }

        #region Muscle Calls
        [TestMethod]
        public void FetchAllMuscles()
        {

        }

        #endregion
    }
}
