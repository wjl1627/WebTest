using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using DapperDao;
using Microsoft.AspNetCore.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        private IComponentContext _componentContext;//Autofac上下文
        private ITestService _testService;
        public HomeController(ITestService testService, IComponentContext componentContext) {
            _testService = testService;
            _componentContext = componentContext;
        }
        public IActionResult Index()
        {
            var value = _testService.GetTestValue();
            _testService.Update(new Entity.TestDto());


            var service = _componentContext.Resolve<ITestService>();

            var result = service.GetEntities(f => f.Id == 0);

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
