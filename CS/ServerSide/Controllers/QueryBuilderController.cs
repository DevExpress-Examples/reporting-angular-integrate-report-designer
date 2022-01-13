using System.Web.Mvc;
using DevExpress.Web.Mvc.Controllers;

namespace ServerSide.Controllers {
    public class QueryBuilderController : QueryBuilderApiControllerBase {
        public override ActionResult Invoke() {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }
    }
}