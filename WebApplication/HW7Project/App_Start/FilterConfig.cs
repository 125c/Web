﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW7Project.Controllers;

namespace HW7Project.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new LogReporter());
            filters.Add(new HandleErrorAttribute()
            {
                View="Error2"
            });
        }
    }
}