import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PcBuilderService {
  private apiUrl = 'https://localhost:44350/api/';

  constructor(private http: HttpClient) { }

  // Buscar todas as Gpus
  listarGpus(): Observable<any> {
    return this.http.get(`${this.apiUrl}//Gpu`);
  }

  // Buscar componentes compatíveis com o ID selecionado
  getCompatibleComponents(componentId: number): Observable<any> {
    return this.http.get(`${this.apiUrl}/components/compatible/${componentId}`);
  }
}
