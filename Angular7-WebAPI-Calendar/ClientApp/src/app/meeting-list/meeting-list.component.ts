import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { filter, switchMap } from 'rxjs/operators';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-meeting-list',
  templateUrl: './meeting-list.component.html',
  styleUrls: ['./meeting-list.component.css']
})
export class MeetingListComponent implements OnInit {

  constructor(private activeRoute: ActivatedRoute, private router: Router) {
    this.navStart = router.events.pipe(
      filter(evt => evt instanceof NavigationEnd)
    ) as Observable<NavigationEnd>;
  }

  navStart: Observable<NavigationEnd>;

  get selectedMonth(): number {
    return +this.activeRoute.snapshot.paramMap.get('month');
  }

  ngOnInit() {
    this.onMonthSelected(this.selectedMonth);
    this.navStart.subscribe(evt => this.onMonthSelected(this.selectedMonth));
  }

  private onMonthSelected(month: number) {
    console.log(month);
  }

}
