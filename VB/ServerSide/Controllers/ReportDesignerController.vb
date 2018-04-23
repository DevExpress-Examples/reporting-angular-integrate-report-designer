Imports System.Collections.Generic
Imports DevExpress.DataAccess.Sql
Imports DevExpress.Web.Mvc.Controllers
Imports DevExpress.XtraReports.Web.ReportDesigner
Imports System.Web.Mvc

Namespace ServerSide.Controllers
    Public Class ReportDesignerController
        Inherits ReportDesignerApiController

        ' This action processes each internal request from the Report Designer.
        Public Overrides Function Invoke() As ActionResult
            Dim result = MyBase.Invoke()
            ' Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*")
            Return result
        End Function

        ' Create an action to provide the Report Designer with the following initialization data:
        '  - A report (required)
        '  - Available data sources (optional)
        '  - URLs for Invoke actions of reporting controllers (required)
        Public Function GetReportDesignerModel(ByVal reportUrl As String) As ActionResult
            Response.AppendHeader("Access-Control-Allow-Origin", "*")

            Dim modelJsonScript As String = (New ReportDesignerClientSideModelGenerator()).GetJsonModelScript(reportUrl, GetAvailableDataSources(), "ReportDesigner/Invoke", "WebDocumentViewer/Invoke", "QueryBuilder/Invoke") ' The URI path of the controller action that processes requests from the Query Builder. -  The URI path of the controller action that processes requests from the Web Document Viewer. -  The URI path of the controller action that processes requests from the Report Designer. -  Obtain data sources that will be available in the Report Designer for adding to reports. -  Obtain a report to open in the Report Designer on application start.
            Return Content(modelJsonScript, "application/json")
        End Function

        Private Function GetAvailableDataSources() As Dictionary(Of String, Object)
            Dim dataSources = New Dictionary(Of String, Object)()
            Dim ds As New SqlDataSource("Northwind_Connection")
            Dim query = SelectQueryFluentBuilder.AddTable("Products").SelectAllColumns().Build("Products")
            ds.Queries.Add(query)
            ds.RebuildResultSchema()
            dataSources.Add("SqlDataSource", ds)
            Return dataSources
        End Function
    End Class
End Namespace