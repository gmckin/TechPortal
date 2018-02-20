using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechPortal.Data.Domain.Crud;
using TechPortal.Data.Domain.DataAccessObjects;

namespace TechPortal.Data.Domain.Crud.Tests
{
    public partial class AccessHelperTests
    {
        [TestMethod()]
        public void DeleteJobTitleTest()
        {
            AccessHelper ah = new AccessHelper();
            var title = ah.GetJobTitles().FirstOrDefault(x => x.JobTitleName == "Lowly Assistant");
            var toDelete = ah.DeleteJobTitle(title);

            Assert.IsTrue(toDelete);
        }
    }
}