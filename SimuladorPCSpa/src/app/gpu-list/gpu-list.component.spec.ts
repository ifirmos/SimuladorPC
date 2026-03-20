import { ComponentFixture, TestBed } from '@angular/core/testing';
import { provideHttpClient } from '@angular/common/http';

import { GpuListComponent } from './gpu-list.component';

describe('GpuListComponent', () => {
  let component: GpuListComponent;
  let fixture: ComponentFixture<GpuListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GpuListComponent],
      providers: [provideHttpClient()],
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(GpuListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
