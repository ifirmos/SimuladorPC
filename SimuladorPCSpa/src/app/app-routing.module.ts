import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GpuListComponent } from './gpu-list/gpu-list.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'gpus', component: GpuListComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
