import { bootstrapApplication } from '@angular/platform-browser';
import { PcBuilderComponent } from './app/pc-builder/pc-builder.component';
import { provideHttpClient } from '@angular/common/http';
import { appConfig } from './app/app.config';

bootstrapApplication(PcBuilderComponent, {
  providers: [
    ...appConfig.providers,
    provideHttpClient()
  ]
}).catch(err => console.error(err));
