import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MeetingDetailsComponent } from './meeting-details/meeting-details.component';
import { MeetingListComponent } from './meeting-list/meeting-list.component';

const routes: Routes = [
  {
    path: 'calendar/:month',
    component: MeetingListComponent,
    children: [
      {
        path: 'meeting/:id',
        component: MeetingDetailsComponent,
      }
    ]
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
