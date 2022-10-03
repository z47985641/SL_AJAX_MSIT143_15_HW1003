using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_AJAX_MSIT143_15_HW1003.Controllers
{
    public class HWAJAXController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
