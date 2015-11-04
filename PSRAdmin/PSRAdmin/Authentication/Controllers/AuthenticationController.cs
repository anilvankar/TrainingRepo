using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace PSRAdmin.Authentication.Controllers
{
    public class AuthenticationController:Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}
