import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GpuListComponent } from './gpu-list/gpu-list.component';
import { HardwareBrowserComponent } from './hardware-browser/hardware-browser.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'gpus', component: GpuListComponent },
  { path: 'hardware-browser', component: HardwareBrowserComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
