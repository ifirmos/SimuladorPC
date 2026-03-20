import { TestBed } from '@angular/core/testing';
import { provideHttpClient } from '@angular/common/http';
import { PcBuilderService } from './pc-builder.service';

describe('PcBuilderService', () => {
  let service: PcBuilderService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [provideHttpClient()]
    });
    service = TestBed.inject(PcBuilderService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
