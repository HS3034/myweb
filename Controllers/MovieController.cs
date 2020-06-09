using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using myweb1.Models;

namespace myweb1.Controllers
{
    public class MovieController :Controller
    {
        public IActionResult index(){
            return  View();
        }

        
    }
}