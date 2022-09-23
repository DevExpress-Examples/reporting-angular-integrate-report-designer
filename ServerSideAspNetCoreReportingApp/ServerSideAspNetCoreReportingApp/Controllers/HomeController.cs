using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DevExpress.XtraReports.UI;


namespace ServerSideAspNetCoreReportingApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Error() {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }
    }
}
