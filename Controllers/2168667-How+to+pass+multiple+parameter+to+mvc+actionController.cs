using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCSamples.Models;

namespace MVCSamples.Controllers
{
    public class _2168667_How_to_pass_multiple_parameter_to_mvc_actionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test1([FromBody] Tuner sdata, string status)
        {
            return Json(new { success = true, responseText = "Your message successfuly sent!" });
        }
    }
}
