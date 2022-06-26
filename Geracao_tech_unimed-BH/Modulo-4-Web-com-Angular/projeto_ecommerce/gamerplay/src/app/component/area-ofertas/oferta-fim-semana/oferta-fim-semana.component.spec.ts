import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OfertaFimSemanaComponent } from './oferta-fim-semana.component';

describe('OfertaFimSemanaComponent', () => {
  let component: OfertaFimSemanaComponent;
  let fixture: ComponentFixture<OfertaFimSemanaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OfertaFimSemanaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OfertaFimSemanaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
