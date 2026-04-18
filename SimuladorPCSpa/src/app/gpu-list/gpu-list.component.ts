import { Component, OnInit } from '@angular/core';
import { PcBuilderService } from '../pc-builder.service';

@Component({
  selector: 'app-gpu-list',
  template: `
    <h1>Lista de GPUs</h1>
    <ul>
      @for (gpu of gpus; track gpu.nome) {
        <li>{{ gpu.nome }} - {{ gpu.modelo }}</li>
      }
    </ul>
  `
})
export class GpuListComponent implements OnInit {
  gpus: any[] = [];

  constructor(private pcBuilderService: PcBuilderService) { }

  ngOnInit(): void {
    this.pcBuilderService.listarGpus().subscribe(data => {
      this.gpus = data;
    });
  }
}
