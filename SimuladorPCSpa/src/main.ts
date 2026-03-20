import { bootstrapApplication } from '@angular/platform-browser';
import { HardwareBrowserComponent } from './app/hardware-browser/hardware-browser.component';
import { importProvidersFrom } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { appConfig } from './app/app.config';

bootstrapApplication(HardwareBrowserComponent, {
  providers: [
    ...appConfig.providers,
    importProvidersFrom(HttpClientModule)
  ]
}).catch(err => console.error(err));
