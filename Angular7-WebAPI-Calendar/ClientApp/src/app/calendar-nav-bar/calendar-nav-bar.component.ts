import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-calendar-nav-bar',
  templateUrl: './calendar-nav-bar.component.html',
  styleUrls: ['./calendar-nav-bar.component.css']
})
export class CalendarNavBarComponent implements OnInit {

  constructor(private activeRoute: ActivatedRoute) { }

  get selectedMonth(): number {
    return +this.activeRoute.snapshot.paramMap.get('id');
  }

  ngOnInit() {
    console.log(this.selectedMonth);
  }

}
