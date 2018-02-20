using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechPortal.Data.Domain;
using TechPortal.Data.Domain.Crud;
using TechPortal.Data.Domain.DataAccessObjects;
using AutoMapper;

namespace TechPortal.Data.DomainTests.Crud
{
    [TestClass()]
    public partial class AccessHelperTests
    {

        //These are INTEGRATION TESTS. DO NOT MISTAKE THESE FOR UNIT TESTS!!!

        [TestMethod()]
        public void ReActivateJobTitleTest()
        {
            AccessHelper ah = new AccessHelper();

            var title = new JobTitleDAO {JobTitleName = "Uber Assistant", IsActive = true};
            JobTitleDAO reactivater = ah.GetInactiveJobTitle().FirstOrDefault(s => s.JobTitleName == title.JobTitleName);
            
            var toInsert = ah.ReActivateJobTitle(reactivater);

            Assert.IsTrue(toInsert);
        }
    }
}

