import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PageHeaderComponent } from './page-header/page-header.component';
import { MeetingDetailsComponent } from './meeting-details/meeting-details.component';
import { CalendarNavBarComponent } from './calendar-nav-bar/calendar-nav-bar.component';
import { MeetingListComponent } from './meeting-list/meeting-list.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    PageHeaderComponent,
    MeetingDetailsComponent,
    CalendarNavBarComponent,
    MeetingListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
