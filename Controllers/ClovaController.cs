using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CEK.CSharp.Models;
using CEK.CSharp;

namespace CoreBot.Controllers
{
    public class ClovaController : Controller
    {
        private ClovaClient client;

        public ClovaController()
        {
            client = new ClovaClient();
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return new OkObjectResult(true);
        }

    }
}
