using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using DataModel;
using System.Linq;

namespace testing.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine("Start Read DataUser");
            using (var db = new RentalContext())
            {
                var ListDataUser = db.data_users.ToList();
            }
            Trace.WriteLine("End Read DataUser");
        }
    }
}
