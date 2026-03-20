import { ComponentFixture, TestBed } from '@angular/core/testing';
import { PcBuilderComponent } from './pc-builder.component';
import { PcBuilderService } from '../pc-builder.service';
import { of } from 'rxjs';
import { provideAnimations } from '@angular/platform-browser/animations';
import { provideHttpClient } from '@angular/common/http';

describe('PcBuilderComponent', () => {
  let component: PcBuilderComponent;
  let fixture: ComponentFixture<PcBuilderComponent>;
  let pcBuilderServiceSpy: jasmine.SpyObj<PcBuilderService>;

  const mockGpu = { nome: 'RTX 4090', modelo: 'Founders Edition' };

  beforeEach(async () => {
    pcBuilderServiceSpy = jasmine.createSpyObj('PcBuilderService', ['listarGpus']);
    pcBuilderServiceSpy.listarGpus.and.returnValue(of([]));

    await TestBed.configureTestingModule({
      imports: [PcBuilderComponent],
      providers: [
        { provide: PcBuilderService, useValue: pcBuilderServiceSpy },
        provideAnimations(),
        provideHttpClient()
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(PcBuilderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should load gpus on init', () => {
    pcBuilderServiceSpy.listarGpus.and.returnValue(of([mockGpu]));

    component.ngOnInit();

    expect(component.gpus).toEqual([mockGpu]);
  });

  it('should clear build on limparBuild', () => {
    component.selectedGpu = mockGpu;
    component.limparBuild();
    expect(component.selectedGpu).toBeNull();
  });

  it('should call confirmarBuild without errors', () => {
    component.selectedGpu = mockGpu;
    expect(() => component.confirmarBuild()).not.toThrow();
  });
});
