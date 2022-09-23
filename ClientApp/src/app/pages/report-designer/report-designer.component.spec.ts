import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportDesignerComponent } from './report-designer.component';

describe('ReportDesignerComponent', () => {
  let component: ReportDesignerComponent;
  let fixture: ComponentFixture<ReportDesignerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportDesignerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportDesignerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
