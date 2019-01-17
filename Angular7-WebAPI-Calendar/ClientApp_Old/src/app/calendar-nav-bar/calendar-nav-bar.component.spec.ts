import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CalendarNavBarComponent } from './calendar-nav-bar.component';

describe('CalendarNavBarComponent', () => {
  let component: CalendarNavBarComponent;
  let fixture: ComponentFixture<CalendarNavBarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CalendarNavBarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CalendarNavBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
