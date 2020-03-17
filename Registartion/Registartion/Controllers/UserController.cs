using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registartion.Models;

namespace Registartion.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddorEdit(int id=0)
        {
            Registration reg = new Registration();
            return View(reg);
        }
    }
}