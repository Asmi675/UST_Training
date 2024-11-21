import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserPlumberPageComponent } from './user-plumber-page.component';

describe('UserPlumberPageComponent', () => {
  let component: UserPlumberPageComponent;
  let fixture: ComponentFixture<UserPlumberPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UserPlumberPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserPlumberPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
