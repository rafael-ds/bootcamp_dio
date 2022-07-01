import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ListaProdutosService {

  constructor() { }

  getProdutos():Observable<any>{
    let arrayProdutos = [
      {
        imagem : 'assets/images/img-produtos/pc-gamer.png',
        descricao: 'Computador Gamer i7 16gb de memória + monitor + teclado + headset',
        valor_real: 'R$ 1,00',
        valor_desconto: 'R$ 10,00',
      },
      {
        imagem : 'assets/images/img-produtos/pc-gamer.png',
        descricao: 'Computador Gamer i7 16gb de memória + monitor + teclado + headset',
        valor_real: 'R$ 5,00',
        valor_desconto: 'R$ 2,00',
      },
      {
        imagem : 'assets/images/img-produtos/pc-gamer.png',
        descricao: 'Computador Gamer i7 16gb de memória + monitor + teclado + headset',
        valor_real: 'R$ 3,00',
        valor_desconto: 'R$ 30,00',
      },
      {
        imagem : 'assets/images/img-produtos/pc-gamer.png',
        descricao: 'Computador Gamer i7 16gb de memória + monitor + teclado + headset',
        valor_real: 'R$ 4,00',
        valor_desconto: 'R$ 40,00',
      },
      {
        imagem : 'assets/images/img-produtos/pc-gamer.png',
        descricao: 'Computador Gamer i7 16gb de memória + monitor + teclado + headset',
        valor_real: 'R$ 5,00',
        valor_desconto: 'R$ 50,00',
      },
      {
        imagem : 'assets/images/img-produtos/pc-gamer.png',
        descricao: 'Computador Gamer i7 16gb de memória + monitor + teclado + headset',
        valor_real: 'R$ 5,00',
        valor_desconto: 'R$ 50,00',
      },
      {
        imagem : 'assets/images/img-produtos/pc-gamer.png',
        descricao: 'Computador Gamer i7 16gb de memória + monitor + teclado + headset',
        valor_real: 'R$ 5,00',
        valor_desconto: 'R$ 50,00',
      },
      {
        imagem : 'assets/images/img-produtos/pc-gamer.png',
        descricao: 'Computador Gamer i7 16gb de memória + monitor + teclado + headset',
        valor_real: 'R$ 5,00',
        valor_desconto: 'R$ 50,00',
      },
    ]

    return of(arrayProdutos)
  }
}
