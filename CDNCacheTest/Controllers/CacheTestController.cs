using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Web;
using CacheTest.Models;

namespace CacheTest.Controllers
{
    public class CacheTestController : Controller
    {
        public CacheTestController()
        {

        }

        public ActionResult CacheTest()
        {
            Response.AddHeader("Cache-Control", "public, max-age=900, s-maxage=900");
             CacheTestModel cacheTestModel = new CacheTestModel();
            ViewBag.Message = "Cache Testing Page.";
            return View(cacheTestModel);
        }
    }
}
