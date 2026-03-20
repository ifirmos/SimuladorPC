import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { CardModule } from 'primeng/card';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CardModule, ButtonModule, RouterLink],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  componentesPc = [
    { nome: 'GPUs', descricao: 'Placas de vídeo para seu computador', icone: 'pi pi-desktop', rota: '/gpus' },
    { nome: 'Monte seu PC', descricao: 'Monte uma configuração completa personalizada', icone: 'pi pi-cog', rota: '/pc-builder' },
  ];
}
