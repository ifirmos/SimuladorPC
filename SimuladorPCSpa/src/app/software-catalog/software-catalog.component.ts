import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardModule } from 'primeng/card';

interface SoftwareCatalogItem {
  id: number;
  nome: string;
  categoria: string;
  versao: string;
  imagemUrl: string;
}

@Component({
  selector: 'app-software-catalog',
  standalone: true,
  imports: [CommonModule, CardModule],
  templateUrl: './software-catalog.component.html',
  styleUrl: './software-catalog.component.css'
})
export class SoftwareCatalogComponent {
  readonly fallbackImage = 'https://placehold.co/220x310?text=Sem+Imagem';

  softwares: SoftwareCatalogItem[] = [
    {
      id: 1,
      nome: 'Cyberpunk 2077',
      categoria: 'RPG',
      versao: '2.1',
      imagemUrl: 'https://upload.wikimedia.org/wikipedia/en/9/9f/Cyberpunk_2077_box_art.jpg'
    },
    {
      id: 2,
      nome: 'The Witcher 3: Wild Hunt',
      categoria: 'RPG',
      versao: '4.04',
      imagemUrl: 'https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg'
    },
    {
      id: 3,
      nome: 'Red Dead Redemption 2',
      categoria: 'Ação/Aventura',
      versao: '1.0.1491.1',
      imagemUrl: 'https://upload.wikimedia.org/wikipedia/en/4/44/Red_Dead_Redemption_II.jpg'
    },
    {
      id: 4,
      nome: 'Elden Ring',
      categoria: 'Soulslike',
      versao: '1.12',
      imagemUrl: 'https://upload.wikimedia.org/wikipedia/en/b/b9/Elden_Ring_Box_art.jpg'
    },
    {
      id: 5,
      nome: 'God of War',
      categoria: 'Ação/Aventura',
      versao: '1.0.12',
      imagemUrl: 'https://upload.wikimedia.org/wikipedia/en/a/a7/God_of_War_4_cover.jpg'
    },
    {
      id: 6,
      nome: 'Baldur\'s Gate 3',
      categoria: 'RPG',
      versao: '4.1.1',
      imagemUrl: 'https://upload.wikimedia.org/wikipedia/en/5/5f/Baldur%27s_Gate_3_cover_art.jpg'
    }
  ];

  onImageError(event: Event): void {
    const img = event.target as HTMLImageElement;
    img.src = this.fallbackImage;
  }
}
