using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AgileChallenge.CST.Web.data;
using Microsoft.AspNetCore.Mvc;
using AgileChallenge.CST.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileChallenge.CST.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void InsertSubject(Subject subject)
        {

            var optionsBuilder = new DbContextOptionsBuilder<AgileChallengeCSTWebContext>();
            optionsBuilder.UseSqlServer("data source=localhost;initial catalog=Challenge02DB;persist security info=True;user id=sa;password=test1234;pooling=False;multipleactiveresultsets=True;application name=EntityFramework");

            using (var context = new AgileChallengeCSTWebContext(optionsBuilder.Options))
            {
                context.Subjects.Add(subject);
                context.SaveChanges();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
