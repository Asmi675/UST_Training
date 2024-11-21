import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserTutorPageComponent } from './user-tutor-page.component';

describe('UserTutorPageComponent', () => {
  let component: UserTutorPageComponent;
  let fixture: ComponentFixture<UserTutorPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UserTutorPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserTutorPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
