Imports DevExpress.Web.Mvc.Controllers
Imports System.Web.Mvc

Namespace ServerSide.Controllers
	Public Class WebDocumentViewerController
		Inherits WebDocumentViewerApiController

		Public Overrides Function Invoke() As ActionResult
			Dim result = MyBase.Invoke()
			' Allow cross-domain requests.
			Response.AppendHeader("Access-Control-Allow-Origin", "*")
			Return result
		End Function
	End Class
End Namespace