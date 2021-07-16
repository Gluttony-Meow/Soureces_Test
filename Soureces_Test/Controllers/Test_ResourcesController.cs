using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soureces_Test.Controllers
{
    public class Test_ResourcesController : Controller
    {
        // GET: Test_Resources
        public ActionResult Index()
        {
            String getLanguage = this.Request.UserLanguages[0];

            try
            {
                string selectLanguage1 = this.Request.UserLanguages[1];
            }
            catch (Exception e)
            {
                throw;
            }
            ViewBag.selectLangua = getLanguage;
            if (getLanguage.Contains("en-AU"))
            {
                return View("Index.en-AU");
            }
            if (getLanguage.Contains("vn-VN"))
            {
                return View("Index.en-AU");
            }
            return View();
        }
    }
}