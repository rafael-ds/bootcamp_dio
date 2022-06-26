import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCarrinhoComponent } from './add-carrinho.component';

describe('AddCarrinhoComponent', () => {
  let component: AddCarrinhoComponent;
  let fixture: ComponentFixture<AddCarrinhoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddCarrinhoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddCarrinhoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
