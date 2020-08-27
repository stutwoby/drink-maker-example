import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DrinkMakerComponent } from './drink-maker.component';

describe('DrinkMakerComponent', () => {
  let component: DrinkMakerComponent;
  let fixture: ComponentFixture<DrinkMakerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DrinkMakerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DrinkMakerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
