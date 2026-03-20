import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GpuListComponent } from './gpu-list/gpu-list.component';
import { SoftwareCatalogComponent } from './software-catalog/software-catalog.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'gpus', component: GpuListComponent },
  { path: 'software-catalog', component: SoftwareCatalogComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
