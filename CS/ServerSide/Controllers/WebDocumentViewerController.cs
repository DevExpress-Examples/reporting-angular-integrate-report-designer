using DevExpress.Web.Mvc.Controllers;
using System.Web.Mvc;

namespace ServerSide.Controllers
{
    public class WebDocumentViewerController : WebDocumentViewerApiController {
        public override ActionResult Invoke() {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }
    }
}