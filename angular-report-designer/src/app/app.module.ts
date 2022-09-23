import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DxReportDesignerModule } from 'devexpress-reporting-angular';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    DxReportDesignerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
