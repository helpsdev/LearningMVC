﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC.Controllers
{
    public class TestController : Controller
    {
        public String GetMessage()
        {
            return "Hello world is old now. It's time for wassup bro ;)";
        }
    }
}