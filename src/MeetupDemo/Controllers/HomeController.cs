using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MeetupDemo.Controllers
{
    public class HomeController : Controller
    {
        private ILogger _logger;

        public HomeController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HomeController>();
        }
        [Route("/")]
        public IActionResult Index()
        {
            _logger.LogInformation("Log from inside controller");
            return View();
        }
    }
}
