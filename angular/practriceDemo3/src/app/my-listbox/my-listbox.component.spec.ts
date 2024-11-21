import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyListboxComponent } from './my-listbox.component';

describe('MyListboxComponent', () => {
  let component: MyListboxComponent;
  let fixture: ComponentFixture<MyListboxComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MyListboxComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MyListboxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
