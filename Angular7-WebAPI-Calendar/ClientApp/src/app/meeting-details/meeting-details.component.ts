import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Meeting } from '../_models/Meeting';
import { Observable } from 'rxjs';
import { filter } from 'rxjs/operators';

@Component({
  selector: 'app-meeting-details',
  templateUrl: './meeting-details.component.html',
  styleUrls: ['./meeting-details.component.css']
})
export class MeetingDetailsComponent implements OnInit {

  constructor(private service: DataService, private activeRoute: ActivatedRoute, private router: Router) {
    this.navigationEndEvent = router.events.pipe(
      filter(evt => evt instanceof NavigationEnd)
    ) as Observable<NavigationEnd>;
  }

  get selectedId(): number {
    return +this.activeRoute.snapshot.paramMap.get('id');
  }
  navigationEndEvent: Observable<NavigationEnd>;

  selectedMeeting: Meeting;

  ngOnInit() {
    this.onMeetingSelected();
    this.navigationEndEvent.subscribe(evt => this.onMeetingSelected());
  }

  onMeetingSelected() {
    this.service.getMeetingDetails(this.selectedId)
      .subscribe(data => {
        this.selectedMeeting = data
      });
  }
}
