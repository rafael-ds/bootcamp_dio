import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SociaisComponent } from './sociais.component';

describe('SociaisComponent', () => {
  let component: SociaisComponent;
  let fixture: ComponentFixture<SociaisComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SociaisComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SociaisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
