import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Card } from 'primeng/card';
import { Button } from 'primeng/button';

@Component({
  selector: 'app-home',
  imports: [Card, Button, RouterLink],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  componentesPc = [
    { nome: 'GPUs', descricao: 'Placas de vídeo para seu computador', icone: 'pi pi-desktop', rota: '/gpus' },
    { nome: 'CPUs', descricao: 'Processadores de alto desempenho', icone: 'pi pi-microchip', rota: '/cpus' },
    { nome: 'Memória RAM', descricao: 'Módulos de memória para seu sistema', icone: 'pi pi-server', rota: '/rams' },
    { nome: 'Armazenamento', descricao: 'SSDs e HDs para guardar seus dados', icone: 'pi pi-database', rota: '/ssds' },
    { nome: 'Placas-Mãe', descricao: 'A base de todo bom computador', icone: 'pi pi-th-large', rota: '/placas-mae' },
    { nome: 'Fontes', descricao: 'Fontes de alimentação confiáveis', icone: 'pi pi-bolt', rota: '/fontes' },
  ];
}
