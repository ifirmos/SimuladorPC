import { Component, OnInit } from '@angular/core';
import { DataView } from 'primeng/dataview';
import { Card } from 'primeng/card';
import { PcBuilderService } from '../pc-builder.service';

@Component({
  selector: 'app-hardware-browser',
  standalone: true,
  imports: [DataView, Card],
  templateUrl: './hardware-browser.component.html',
  styleUrl: './hardware-browser.component.css'
})
export class HardwareBrowserComponent implements OnInit {
  gpus: any[] = [];

  constructor(private pcBuilderService: PcBuilderService) { }

  ngOnInit(): void {
    this.pcBuilderService.listarGpus().subscribe(data => {
      this.gpus = data;
    });
  }
}
