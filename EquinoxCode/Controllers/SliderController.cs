﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquinoxCode.Controllers
{
    public class SliderController : Controller
    {
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}