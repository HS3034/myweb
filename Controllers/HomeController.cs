using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myweb1.Models;

namespace myweb1.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

                        //         
      //  [Route("Privacy")]                 //เข้าได้จากหลายทาง
       // [Route("Home/Privacy/{txt?}")]    //ถ้าใส่เครื่องหมาย ?  จะใส่ไม่ใส่ก็ได้
        [Route("/[controller]/[action]/{mytext?}")]     //สร้างอัติโนมัส  ใช้ token แทน
        public IActionResult Privacy(string txt)
        {
            ViewData["Msg"]="Your Contract Page. :"+txt;
            ViewData["rs"]=1+1;


            return View();
        }

[Route("Home/webcome2")]
         public IActionResult Welcome(){

            return View();

        }

     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
