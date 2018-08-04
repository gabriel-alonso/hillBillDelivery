using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }
    }
}