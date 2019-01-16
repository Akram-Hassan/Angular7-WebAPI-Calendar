import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CalendarNavBarComponent } from './calendar-nav-bar/calendar-nav-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    CalendarNavBarComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    //RouterModule.forRoot([
    //  { path: '', component: HomeComponent, pathMatch: 'full' },
    //])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
