import { Component, ViewEncapsulation, OnInit } from '@angular/core';

@Component({
  selector: 'app-report-designer',
  encapsulation: ViewEncapsulation.None,
  templateUrl: './report-designer.component.html',
  styleUrls: [
    "../../../../node_modules/jquery-ui/themes/base/all.css",
    "../../../../node_modules/devextreme/dist/css/dx.material.orange.light.css",
    "../../../../node_modules/devexpress-richedit/dist/dx.richedit.css",
    "../../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.material.orange.light.css",
    "../../../../node_modules/@devexpress/analytics-core/dist/css/dx-querybuilder.css",
    "../../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css",
    "../../../../node_modules/devexpress-reporting/dist/css/dx-reportdesigner.css"
]
})
export class ReportDesignerComponent implements OnInit {

  constructor() { }

  title = 'DXReportDesignerSample';
  // If you use the ASP.NET Core backend:
  getDesignerModelAction = "/DXXRD/GetDesignerModel";
  // The report name.
  reportName = "TestReport";
  // The backend application URL.
  host = 'https://localhost:5001/';

  ngOnInit(): void {
  }

}
