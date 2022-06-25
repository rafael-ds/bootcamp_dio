import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AreaBannerComponent } from './area-banner.component';

describe('AreaBannerComponent', () => {
  let component: AreaBannerComponent;
  let fixture: ComponentFixture<AreaBannerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AreaBannerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AreaBannerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
