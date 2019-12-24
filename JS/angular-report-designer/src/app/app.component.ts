import { Component, ViewEncapsulation } from '@angular/core';
import 'devexpress-reporting/dx-richedit';

@Component({
selector: 'app-root',
encapsulation: ViewEncapsulation.None,
templateUrl: './app.component.html',
styleUrls: [
        './app.component.css',
        "../../node_modules/jquery-ui/themes/base/all.css",
        "../../node_modules/devextreme/dist/css/dx.common.css",
        "../../node_modules/devextreme/dist/css/dx.light.css",
        "../../node_modules/devexpress-richedit/dist/dx.richedit.css",
        "../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
        "../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.light.css",
        "../../node_modules/@devexpress/analytics-core/dist/css/dx-querybuilder.css",
        "../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css",
        "../../node_modules/devexpress-reporting/dist/css/dx-reportdesigner.css"
]
})

export class AppComponent {
title = 'DXReportDesignerSample';
getDesignerModelAction = "/ReportDesigner/GetReportDesignerModel";
reportUrl = "Products";
hostUrl = 'http://localhost:54111/';
}
