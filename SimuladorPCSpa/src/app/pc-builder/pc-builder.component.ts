import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Panel } from 'primeng/panel';
import { Select } from 'primeng/select';
import { Button } from 'primeng/button';
import { PcBuilderService } from '../pc-builder.service';

interface Gpu {
  nome: string;
  modelo: string;
}

@Component({
  selector: 'app-pc-builder',
  imports: [FormsModule, Panel, Select, Button],
  templateUrl: './pc-builder.component.html',
  styleUrl: './pc-builder.component.css'
})
export class PcBuilderComponent implements OnInit {
  gpus: Gpu[] = [];
  selectedGpu: Gpu | null = null;

  constructor(private pcBuilderService: PcBuilderService) {}

  ngOnInit(): void {
    this.pcBuilderService.listarGpus().subscribe((data: Gpu[]) => {
      this.gpus = data;
    });
  }

  confirmarBuild(): void {
    console.log('Build confirmado:', { gpu: this.selectedGpu });
  }

  limparBuild(): void {
    this.selectedGpu = null;
  }
}
