using System.Collections.Generic;
using System.Web.Mvc;
using DevExpress.DataAccess.Sql;
using DevExpress.Web.Mvc.Controllers;
using DevExpress.XtraReports.Web.ReportDesigner;

namespace ServerSide.Controllers {
    public class ReportDesignerController : ReportDesignerApiControllerBase {
        // This action processes each internal request from the Report Designer.
        public override ActionResult Invoke() {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }

        // Create an action to provide the Report Designer with the following initialization data:
        //  - A report (required)
        //  - Available data sources (optional)
        //  - URLs for Invoke actions of reporting controllers (required)
        public ActionResult GetReportDesignerModel(string reportUrl) {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            string modelJsonScript =
                new ReportDesignerClientSideModelGenerator()
                .GetJsonModelScript(
                    reportUrl,                 // Obtain a report to open in the Report Designer on application start.
                    GetAvailableDataSources(), // Obtain data sources that will be available in the Report Designer for adding to reports.
                    "ReportDesigner/Invoke",   // The URI path of the controller action that processes requests from the Report Designer.
                    "WebDocumentViewer/Invoke",// The URI path of the controller action that processes requests from the Web Document Viewer.
                    "QueryBuilder/Invoke"      // The URI path of the controller action that processes requests from the Query Builder.
                );
            return Content(modelJsonScript, "application/json");
        }

        Dictionary<string, object> GetAvailableDataSources() {
            var dataSources = new Dictionary<string, object>();
            SqlDataSource ds = new SqlDataSource("Northwind_Connection");
            var query = SelectQueryFluentBuilder.AddTable("Products").SelectAllColumns().Build("Products");
            ds.Queries.Add(query);
            ds.RebuildResultSchema();
            dataSources.Add("SqlDataSource", ds);
            return dataSources;
        }
    }
}