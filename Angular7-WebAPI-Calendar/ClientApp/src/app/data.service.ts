import { Injectable } from '@angular/core';
import { Meeting } from './_models/Meeting';
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})

export class DataService {

  constructor() { }

  fakeData = [
    {
      id: 1,
      date: new Date(2000,1,1),
      name: "mock event 1",
      attendees: [
        { id: 1, name: "Att 1" },
        { id: 2, name: "Att 2" },
        { id: 3, name: "Att 3" }
      ]
    },
    {
      id: 2,
      date: new Date(2000, 1, 1),
      name: "mock event 2",
      attendees: [
        { id: 4, name: "Att 4" },
        { id: 5, name: "Att 5" },
        { id: 6, name: "Att 6" }
      ]
    },
    {
      id: 3,
      date: new Date(2000, 3, 1),
      name: "mock event 3",
      attendees: [
        { id: 6, name: "Att 6" },
        { id: 7, name: "Att 7" },
        { id: 8, name: "Att 8" }
      ]
    },
    {
      id: 4,
      date: new Date(2000, 4, 1),
      name: "mock event 4",
      attendees: [
        { id: 9, name: "Att 9" },
        { id: 10, name: "Att 10" },
      ]
    }
  ]


  getMonthMeetings(month: number): Observable<Meeting[]> {
    return of(this.fakeData.filter(x => x.date.getMonth()  == month));
  }

  getMeetingDetails(id: number) {
    return of(this.fakeData.filter(x => x.id == id)[0]);
  }
}
