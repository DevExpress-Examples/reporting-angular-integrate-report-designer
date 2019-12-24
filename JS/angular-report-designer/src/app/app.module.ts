import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';

import { DxReportDesignerModule } from 'devexpress-reporting-angular';

@NgModule({
declarations: [
    AppComponent
],
imports: [
    BrowserModule,
    DxReportDesignerModule
],
providers: [],
bootstrap: [AppComponent]
})
export class AppModule { }
