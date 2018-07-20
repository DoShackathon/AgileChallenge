using System.Linq;
using AgileChallenge.CST.Web.Controllers;
using AgileChallenge.CST.Web.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgileChallenge.CST.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arranage
            var optionsBuilder = new DbContextOptionsBuilder<AgileChallengeCSTWebContext>();
            optionsBuilder.UseSqlServer(
                "data source=localhost;initial catalog=Challenge02DB;persist security info=True;user id=sa;password=test1234;pooling=False;multipleactiveresultsets=True;application name=EntityFramework");

            using (var context = new AgileChallengeCSTWebContext(optionsBuilder.Options))
            {
                int preCount = context.Subjects.Count();
                Subject subject = new Subject()
                {
                    FirstName = "AzureLord",
                    LastName = "Giri",
                    MiddleName = "Linux",
                    AddressLine1 = "1 Microsoft Way",
                    AddressLine2 = "The Genius Floor",
                    City = "Socrates",
                    StateCode = "VA",
                    ZipCode = "22193",
                    CountryCode = "USA",
                    EmailAddress = "IAmGreat@MSCEO.com",
                    MobilePhone = "123-345-6789"
                };

                HomeController homeController =new HomeController();
                homeController.InsertSubject(subject);

                Assert.AreEqual(++preCount, context.Subjects.Count());
            }
        }
    }
}