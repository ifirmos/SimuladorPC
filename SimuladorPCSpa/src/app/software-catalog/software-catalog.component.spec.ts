import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SoftwareCatalogComponent } from './software-catalog.component';

describe('SoftwareCatalogComponent', () => {
  let component: SoftwareCatalogComponent;
  let fixture: ComponentFixture<SoftwareCatalogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SoftwareCatalogComponent]
    }).compileComponents();

    fixture = TestBed.createComponent(SoftwareCatalogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should have a non-empty softwares list', () => {
    expect(component.softwares.length).toBeGreaterThan(0);
  });

  it('should replace image src with fallback on error', () => {
    const imgEl = fixture.debugElement.query(
      el => el.nativeElement.tagName === 'IMG'
    );
    const imgNative = imgEl.nativeElement as HTMLImageElement;
    imgEl.triggerEventHandler('error', { target: imgNative });
    expect(imgNative.src).toContain('placehold.co');
  });
});
