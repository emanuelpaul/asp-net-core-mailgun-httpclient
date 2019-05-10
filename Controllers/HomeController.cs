using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp_net_core_mailgun_httpclient.Models;
using asp_net_core_mailgun_httpclient.Services;

namespace asp_net_core_mailgun_httpclient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender emaiSender;

        public HomeController(IEmailSender emaiSender)
        {
            this.emaiSender = emaiSender;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendTestMail()
        {
            return RedirectToAction("Index");
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
