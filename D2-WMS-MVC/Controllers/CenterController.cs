using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace D2_WMS_MVC.Controllers
{
    public class CenterController : Controller
    {
        private IConfiguration _configuration;
        public IActionResult Index()
        {
            return View();
        }
        public CenterController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public IActionResult Show()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
    }
}
