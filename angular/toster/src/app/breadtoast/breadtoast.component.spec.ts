import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BreadtoastComponent } from './breadtoast.component';

describe('BreadtoastComponent', () => {
  let component: BreadtoastComponent;
  let fixture: ComponentFixture<BreadtoastComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BreadtoastComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BreadtoastComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
