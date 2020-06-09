using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using myweb1.Models;

namespace myweb1.Controllers

{
    public class HelloWorldController : Controller
    {
        // [Route("HelloWorld/Action1/{str?}")]
        public IActionResult Action1(DateTime id){
                
                // if(!string.IsNullOrEmpty(str)){
                //         return Content("Hellow World"+str);
                // }else{
                //     return  NotFound();
                // }

                ViewData["CurrentDate"] = id;
                ViewData["Tomorow"] = id.AddDays(1);

                // return Content("HELLO WORLD"+str);
                var movies = new List<Movie>();
                
                movies.Add(new Movie{
                    id=1,
                    name="star war",
                    price=  210
                });

                movies.Add(new Movie{
                    id=2,
                    name ="Bat man",
                    price= 200
                });

                // ViewData["mydata"]= movies;
                return View(movies);
        }

        public IActionResult Action2(){

            return View();
        }

    }
}