﻿using System.Web;
using System.Web.Mvc;

namespace Parcial2_EmilyRoss
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
