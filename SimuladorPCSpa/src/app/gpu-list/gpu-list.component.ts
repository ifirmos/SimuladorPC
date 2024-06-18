import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PcBuilderService } from '../pc-builder.service';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-gpu-list',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  template: `
    <h1>Lista de GPUs</h1>
    <ul>
      <li *ngFor="let gpu of gpus">
        {{ gpu.nome }} - {{ gpu.modelo }}
      </li>
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
