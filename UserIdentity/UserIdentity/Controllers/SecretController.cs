using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserIdentity.Controllers
{
    public class SecretController : Controller
    {
        // GET: Secret
        public ActionResult Index()
        {
            return View();
        }

        public string Secret() {
            return "Secret";
        }

        public string Overt() {
            return "Not a secret";
        }
    }
}