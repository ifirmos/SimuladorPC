import { Component, OnInit } from '@angular/core';
import { PcBuilderService } from '../pc-builder.service';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';


@Component({
  selector: 'app-pc-builder',
  templateUrl: './pc-builder.component.html',
  standalone: true,
  imports: [FormsModule, RouterModule]
})

export class PcBuilderComponent implements OnInit {
  Gpus: any[] = [];
  selectedGpuId: string = "";
  compatibleComponents: any[] = [];

  constructor(private pcBuilderService: PcBuilderService) { }

  ngOnInit(): void {
    this.pcBuilderService.listarGpus().subscribe(components => {
      this.Gpus = components;
    });
  }
}
