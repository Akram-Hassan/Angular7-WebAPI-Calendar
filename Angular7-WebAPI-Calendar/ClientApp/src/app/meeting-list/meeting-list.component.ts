import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { filter, switchMap } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { DataService } from '../data.service';
import { Meeting } from '../_models/Meeting';


@Component({
  selector: 'app-meeting-list',
  templateUrl: './meeting-list.component.html',
  styleUrls: ['./meeting-list.component.css']
})
export class MeetingListComponent implements OnInit {

  constructor(private activeRoute: ActivatedRoute, private router: Router, private service: DataService) {
    this.navStart = router.events.pipe(
      filter(evt => evt instanceof NavigationEnd)
    ) as Observable<NavigationEnd>;
  }

  navStart: Observable<NavigationEnd>;
  selectedData: Meeting[];

  get selectedMonth(): number {
    return +this.activeRoute.snapshot.paramMap.get('month');
  }

  ngOnInit() {
    this.onMonthSelected(this.selectedMonth);
    this.navStart.subscribe(evt => this.onMonthSelected(this.selectedMonth));
  }

  private onMonthSelected(month: number) {
    console.log(month);
    this.service.getMonthMeetings(month)
      .subscribe(data => {
        this.selectedData = data
      });
  }
}
