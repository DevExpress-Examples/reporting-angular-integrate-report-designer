<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T566422)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to Integrate Web Report Designer in Angular App

This project consists of an Angular client (front-end) application and an ASP.NET Core server (back-end) application. 

The `ClientApp` folder contains the Angular app created from the DevExtreme template as described in the following help topics:

- [Create a DevExtreme Application](https://js.devexpress.com/Documentation/Guide/Angular_Components/Getting_Started/Create_a_DevExtreme_Application/)
- [Create an Angular Front-End Application with a Report Designer](https://docs.devexpress.com/XtraReports/119431/web-reporting/javascript-reporting/angular/report-designer/quick-start/report-designer-integration-in-angular)

The `dx.material.orange.light` theme is applied to the Report Designer component as described in the following help topic: [Themes and Styles in Angular Application](https://docs.devexpress.com/XtraReports/403931/web-reporting/javascript-reporting/angular/themes-and-styles?p=netframework).

The `ServerSideAspNetCoreReportingApp` folder contains the ASP.NET Core server (back-end) application created as described in the following help topic: [Report Designer Server-Side Configuration (ASP.NET Core)](https://docs.devexpress.com/XtraReports/400196/web-reporting/javascript-reporting/server-side-configuration/report-designer/report-designer-server-side-configuration-asp-net-core). The application enables [cross-domain requests (CORS)](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS) (Access-Control-Allow-Origin) and implements a custom web report storage.

The `angular-report-designer` contains the sample Angular application created by following the steps in the [Client (Front-End) Application](https://docs.devexpress.com/XtraReports/119431/web-reporting/javascript-reporting/angular/report-designer/quick-start/report-designer-integration-in-angular?f=theme#client-front-end-application) help topic section.

When you start the back-end application and run the Angular application in the `ClientApp` folder, it appears as follows:

![Web Report Designer Angular App](images/screenshot.png)


## How to Run the Project

To run the project, start the `ServerSideAspNetCoreReportingApp` application, install npm packages with `npm install` command in the `ClientApp` folder, and run the command  `ng serve`.

Before you run the project, verify the DevExpress version. If necessary, upgrade it to the DevExpress version you're currently using. Make sure to use the same version of DevExpress components for both Front-end and Back-end applications.

Follow these steps to update the project:

### Upgrade the server-side app

Use the [DevExpress Project Converter](https://docs.devexpress.com/ProjectConverter/2529/project-converter) to upgrade assembly references for the back-end project solution. You can open the project in Visual Studio and navigate to the Menu: Extensions -> DevExpress -> Project Converter. Select the required version and upgrade the project.

### Upgrade the client-side app

Navigate to the `package.json` file in the `ClientApp` folder and change all DevExpress script versions to the version you're using on the server side. If you're using v22.1.6, modify the package.json file as follows:

```
    {
        ...
        "devextreme": "22.1.6",
        "devexpress-richedit": "22.1.6",
        "@devexpress/analytics-core": "22.1.6",
        "devexpress-reporting-angular": "22.1.6"
        ...
    }
```

Open the `ClientApp` folder in the console and run the command to download updated packages:

```
npm install
```

### Run the Example
Perform the following steps to run this example:

1. Open the back-end project solution (`ServerSideAspNetCoreReportingApp\ServerSideAspNetCoreReportingApp.sln`) in Visual Studio and run the project.
2. Navigate to the `ClientApp` folder that is the client part's root folder.
3. Open the console and run the following command:

    ```npm install```

4. Run the command to compile and start the client part:

    ```ng serve```

5. Open your browser at [http://localhost:4200/](http://localhost:4200/) to see the result.

### Troubleshooting 

The following articles help troubleshoot and resolve issues that may occur in web reporting applications:
* [Troubleshooting](https://docs.devexpress.com/XtraReports/401726/web-reporting/general-information/troubleshooting)
* [Reporting Application Diagnostics](https://docs.devexpress.com/XtraReports/401687/web-reporting/general-information/application-diagnostics)

## Files to Review

Client App

- [package.json](ClientApp\package.json)
- [app.module.ts](ClientApp\src\app\app.module.ts)
- [report-designer.component.html](ClientApp\src\app\pages\report-designer\report-designer.component.html)
- [report-designer.component.ts](ClientApp\src\app\pages\report-designer\report-designer.component.ts)

Server App

- [Startup.cs](ServerSideAspNetCoreReportingApp\ServerSideAspNetCoreReportingApp\Startup.cs)
- [ReportingControllers.cs](ServerSideAspNetCoreReportingApp\ServerSideAspNetCoreReportingApp\Controllers\ReportingControllers.cs)

## More Examples

* [How to use the Web Document Viewer in JavaScript with Angular](https://github.com/DevExpress-Examples/Reporting_how-to-use-the-web-document-viewer-in-javascript-with-angular-t566419)






