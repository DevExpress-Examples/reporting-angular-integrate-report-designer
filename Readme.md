# How to use the Web Report Designer in JavaScript with Angular

This example consists of two parts: 

- A server (back-end) ASP.NET MVC project that enables [cross-domain requests (CORS)](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS) (Access-Control-Allow-Origin) and implements a custom web report storage.

- An <a href="https://angular.io/">Angular</a> front-end client application.

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

**See also**:

* [How to use the Web Document Viewer in JavaScript with Angular](https://github.com/DevExpress-Examples/Reporting_how-to-use-the-web-document-viewer-in-javascript-with-angular-t5664192) example on GitHub




