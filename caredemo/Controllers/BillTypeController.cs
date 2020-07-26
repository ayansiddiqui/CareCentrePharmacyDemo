﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace caredemo.Controllers
{
    [Authorize(Roles = Pages.MainMenu.BillType.RoleName)]
    public class BillTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}