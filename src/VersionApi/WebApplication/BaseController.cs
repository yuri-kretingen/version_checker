using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication
{
    public class BaseController : Controller
    {
        // GET
        public string Version()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            if (version is not null)
            {
                return version.ToString();
            }

            return "0.0.0";
        }

        public string SetVersion()
        {
            return "test";
        }
    }
}