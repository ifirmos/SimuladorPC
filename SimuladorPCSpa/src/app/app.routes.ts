import { Routes } from '@angular/router';
import { GpuListComponent } from './gpu-list/gpu-list.component';
import { HomeComponent } from './home/home.component';
import { HardwareBrowserComponent } from './hardware-browser/hardware-browser.component';

export const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'gpus', component: GpuListComponent },
  { path: 'hardware-browser', component: HardwareBrowserComponent },
];
