using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MadiatrTests.Controllers
{
    public class HomeController: BaseController
    {

        [HttpGet]
        public ActionResult UserOrders()
        {

            return Ok("ok");
        }


    }
}
