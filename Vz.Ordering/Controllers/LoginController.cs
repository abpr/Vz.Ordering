using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vz.Ordering.Models;

namespace Vz.Ordering.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string ValidateCredentials(string strUserID, string strPwd)
        {
            LoginModel objLoginModel = new LoginModel();
            return objLoginModel.isUserValid(strUserID, strPwd);
        }

    }
}
