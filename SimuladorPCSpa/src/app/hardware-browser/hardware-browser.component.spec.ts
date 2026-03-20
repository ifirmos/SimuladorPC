import { ComponentFixture, TestBed } from '@angular/core/testing';
import { provideHttpClient } from '@angular/common/http';
import { provideHttpClientTesting } from '@angular/common/http/testing';
import { of } from 'rxjs';
import { HardwareBrowserComponent } from './hardware-browser.component';
import { PcBuilderService } from '../pc-builder.service';

describe('HardwareBrowserComponent', () => {
  let component: HardwareBrowserComponent;
  let fixture: ComponentFixture<HardwareBrowserComponent>;
  let pcBuilderServiceSpy: jasmine.SpyObj<PcBuilderService>;

  beforeEach(async () => {
    pcBuilderServiceSpy = jasmine.createSpyObj('PcBuilderService', ['listarGpus']);
    pcBuilderServiceSpy.listarGpus.and.returnValue(of([]));

    await TestBed.configureTestingModule({
      imports: [HardwareBrowserComponent],
      providers: [
        provideHttpClient(),
        provideHttpClientTesting(),
        { provide: PcBuilderService, useValue: pcBuilderServiceSpy }
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(HardwareBrowserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should load GPUs on init', () => {
    const mockGpus = [
      {
        id: 1,
        nome: 'RTX 4090',
        fabricante: { nome: 'NVIDIA', site: 'https://nvidia.com' },
        qtdMemoriaEmGb: 24,
        frequenciaBaseMhz: 2235,
        potenciaRecomendadaEmWatts: 850
      }
    ];
    pcBuilderServiceSpy.listarGpus.and.returnValue(of(mockGpus));

    component.ngOnInit();

    expect(component.gpus).toEqual(mockGpus);
  });

  it('should display page heading', () => {
    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('h2')?.textContent).toContain('Navegador de Hardware');
  });
});
