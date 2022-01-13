<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596902/21.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T566422)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to use the Web Report Designer in JavaScript with Angular

## Upgrade the Project
Before you run the project, verify the DevExpress version. If necessary, upgrade it to the DevExpress version you're currently using. Make sure to use the same version of DevExpress components for both Front-end and Back-end applications.

Follow these steps to update the project:

### Upgrade the server-side app

Use the [DevExpress Project Converter](https://docs.devexpress.com/ProjectConverter/2529/project-converter) to upgrade assembly references for the back-end project solution (**CS\ServerSide.sln** or **VB\ServerSide.sln**). You can open the project in Visual Studio and navigate to the Menu: Extensions -> DevExpress -> Project Converter. Select the required version and upgrade the project.

### Upgrade the client-side app

Navigate to the `package.json` file in the **JS\angular-report-designer** folder and change all DevExpress script versions to the version you're using on the server side. For instance, if you're using v20.2.6, modify the package.json file as follows:

```
    {
        ...
        "devextreme": "20.2.6",
        "devexpress-richedit": "20.2.6",
        "@devexpress/analytics-core": "20.2.6",
        "devexpress-reporting-angular": "20.2.6"
        ...
    }
```

Open the **JS\angular-report-designer** folder in the console and run the command to download updated packages:
```
npm install
```

## Implementation Details
This example consists of two parts: 

- A server (back-end) ASP.NET MVC project that enables [cross-domain requests (CORS)](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS) (Access-Control-Allow-Origin) and implements a custom web report storage.

- An <a href="https://angular.io/">Angular</a> front-end client application.

### Run the Example
Perform the following steps to run this example:

1. Open the back-end project solution (**CS\ServerSide.sln** or **VB\ServerSide.sln**) in Visual Studio and run the project.
2. Navigate to the **JS\angular-report-designer** folder that is the client part's root folder.
3. Open the console and run the following command:

    ```npm install```

4. Run the command to compile and start the client part:

    ```ng serve```

5. Open your browser at [http://localhost:4200/](http://localhost:4200/) to see the result.

![](images/screenshot.png)


For a step-by-step tutorial, refer to the
[Report Designer Integration in Angular](https://docs.devexpress.com/XtraReports/119431) topic.

## Troubleshooting 
The following articles help troubleshoot and resolve issues that may occur in web reporting applications:
* [Troubleshooting](https://docs.devexpress.com/XtraReports/401726/web-reporting/general-information/troubleshooting)
* [Reporting Application Diagnostics](https://docs.devexpress.com/XtraReports/401687/web-reporting/general-information/application-diagnostics)

## See also

* [How to use the Web Document Viewer in JavaScript with Angular](https://github.com/DevExpress-Examples/Reporting_how-to-use-the-web-document-viewer-in-javascript-with-angular-t566419) example on GitHub




