using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
    public class DemoController:Controller
    {

        public async Task<IActionResult> Index()
        {
            await Task.FromResult(0);
            return View();

        }
    }
}
