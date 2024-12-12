using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SleighList.Controllers
{
    [Route("[controller]")]
    public class ItemController : Controller
    {
        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
        }
        
        // public IActionResult ListaProdutos() {
        // return View(); 
        // }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Editar")]
        public IActionResult Editar()
        {
            return View();
        }

        

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}