import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from "@angular/forms";
import { DataService } from './services/DataService';
//import { JsonPipe } from '@angular/common';
 
@NgModule({
  declarations: [
    AppComponent,
//    JsonPipe
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
//    HttpClientModule
  ],
  providers: [
    DataService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
