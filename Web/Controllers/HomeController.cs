using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
      //  private readonly ISingletonDateService _singletonDateService;
     //   private readonly IScopedDateService _scopedDateService;
        private readonly ITransientDateService _transientDateService;

        // constructor injection
        public HomeController(ITransientDateService transientDateService)
        {
            _transientDateService = transientDateService;
            
        }

        // method injection
        public IActionResult Index([FromServices] ISingletonDateService singletonDateService2)
        {       
            // her requestre aynı saat, çünkü bir defa nesne örneği oluşturuldu.
            // singleton olduğu için aynı tarih olacak.
          //  ViewBag.time1 = _singletonDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = singletonDateService2.GetDateTime.TimeOfDay.ToString();

            return View();
        }
        public IActionResult Index2([FromServices] IScopedDateService scopedDateService2)
        {
            // her requestte yeni nesne örneği
            // o request boyunca aynı nesneyi kullandığı için saatler aynı
         //   ViewBag.time1 = _scopedDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = scopedDateService2.GetDateTime.TimeOfDay.ToString();

            return View();
        }
        public IActionResult Index3([FromServices] ITransientDateService transientDateService2)
        {
            // her injectionda yeni nesne örneği : saatler farklı.
            
            ViewBag.time1 = _transientDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = transientDateService2.GetDateTime.TimeOfDay.ToString();

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
