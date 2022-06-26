import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AreaOfertasComponent } from './area-ofertas.component';

describe('AreaOfertasComponent', () => {
  let component: AreaOfertasComponent;
  let fixture: ComponentFixture<AreaOfertasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AreaOfertasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AreaOfertasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
