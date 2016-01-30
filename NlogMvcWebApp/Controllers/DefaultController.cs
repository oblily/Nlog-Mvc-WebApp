using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NlogMvcWebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Debug("Debug Logging test");
            logger.Info("Info Logging test");
            logger.Warn("Warn Logging test");
            logger.Error("Error Logging test");
            logger.Fatal("Fatal Logging test");

            return View();
        }
    }
}