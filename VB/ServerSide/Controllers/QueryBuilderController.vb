Imports System.Web.Mvc
Imports DevExpress.Web.Mvc.Controllers

Namespace ServerSide.Controllers
	Public Class QueryBuilderController
		Inherits QueryBuilderApiController

		Public Overrides Function Invoke() As ActionResult
			Dim result = MyBase.Invoke()
			' Allow cross-domain requests.
			Response.AppendHeader("Access-Control-Allow-Origin", "*")
			Return result
		End Function
	End Class
End Namespace