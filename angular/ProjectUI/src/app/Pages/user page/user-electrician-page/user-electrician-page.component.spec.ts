import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserElectricianPageComponent } from './user-electrician-page.component';

describe('UserElectricianPageComponent', () => {
  let component: UserElectricianPageComponent;
  let fixture: ComponentFixture<UserElectricianPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UserElectricianPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserElectricianPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
