import { Injectable } from '@angular/core';
import { Meeting } from './_models/Meeting';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';


class Api {
  private static apiRootUrl = "api/data"

  static meetingListUrl(month: number): string {
    return `${this.apiRootUrl}/meetings/${month}`;
  }

  static meetingDetailsUrl(id: number): string {
    return `${this.apiRootUrl}/meeting/${id}`;
  }
}

@Injectable({
  providedIn: 'root'
})
export class DataService {
  constructor(private http: HttpClient) { }

  getMonthMeetings(month: number): Observable<Meeting[]> {
    return this.http.get<Meeting[]>(Api.meetingListUrl(month));
  }

  getMeetingDetails(id: number) {
    return this.http.get<Meeting>(Api.meetingDetailsUrl(id));
  }
}
