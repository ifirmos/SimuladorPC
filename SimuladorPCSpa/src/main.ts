import { bootstrapApplication } from '@angular/platform-browser';
import { GpuListComponent } from './app/gpu-list/gpu-list.component';
import { importProvidersFrom } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { appConfig } from './app/app.config';

bootstrapApplication(GpuListComponent, {
  providers: [
    ...appConfig.providers,
    importProvidersFrom(HttpClientModule)
  ]
}).catch(err => console.error(err));
