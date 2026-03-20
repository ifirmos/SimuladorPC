import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HardwareBrowserComponent } from './hardware-browser.component';
import { PcBuilderService } from '../pc-builder.service';
import { of } from 'rxjs';

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
      { id: 1, nome: 'RTX 4090', fabricante: 'NVIDIA', qtdMemoriaEmGb: 24, frequenciaBaseMhz: 2235, potenciaRecomendadaEmWatts: 850 }
    ];
    pcBuilderServiceSpy.listarGpus.and.returnValue(of(mockGpus));

    component.ngOnInit();

    expect(component.gpus).toEqual(mockGpus);
  });
});
