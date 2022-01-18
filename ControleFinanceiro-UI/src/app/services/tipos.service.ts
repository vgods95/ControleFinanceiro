import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Tipo } from '../models/Tipo';

@Injectable({
  providedIn: 'root'
})
export class TiposService {

  url:string = 'api/Tipos';

  constructor(private http: HttpClient) { }

  //Observable é um tipo que mantém seus dependentes (no caso o array de Tipos) sendo observados
  //E os notifica automaticamente sobre mudanças de estado. O consumidor desse método receberá notificações
  PegarTodos() : Observable<Tipo[]>{
    return this.http.get<Tipo[]>(this.url);
  }
}
