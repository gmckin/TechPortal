using System.Linq;
using Xunit;
using TechPortal.Data.Domain.Crud;

namespace TechPortal.Data.Test.CrudTests
{
    public partial class Tester
    {
        //[TestMethod()]
        public void Test_DeleteJobTitle()
        {
            AccessHelper ah = new AccessHelper();
            var title = ah.GetJobTitles().Single(x => x.JobTitleName == "Lowly Assistant");
            var toDelete = ah.DeleteJobTitle(title);
            var actual = ah.GetJobTitles().Single(x => x.JobTitleName == "Lowly Assistant");

            Assert.True(actual.IsActive);
        }

    }
}
