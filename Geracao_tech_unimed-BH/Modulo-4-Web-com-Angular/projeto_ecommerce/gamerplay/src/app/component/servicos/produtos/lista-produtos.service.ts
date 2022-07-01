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
        valor_real: 'R$ 3599,00',
        valor_desconto: 'R$ 2999,00',
      },
      {
        imagem : 'assets/images/img-produtos/joy-ps5.png',
        descricao: 'Controle ps5 tema Dragon Ball.',
        valor_real: 'R$ 690,00',
        valor_desconto: 'R$ 450,00',
      },
      {
        imagem : 'assets/images/img-produtos/microfone.webp',
        descricao: 'Microfoner Gamer Semi-Profissional Anti Ruídos.',
        valor_real: 'R$ 920,00',
        valor_desconto: 'R$ 799,00',
      },
      {
        imagem : 'assets/images/img-produtos/not_gamer.png',
        descricao: 'Notebool Gamer i5 Geforce 1600ti 16gb SSD 250.',
        valor_real: 'R$ 5300,00',
        valor_desconto: 'R$ 4500,00',
      },
      {
        imagem : 'assets/images/img-produtos/gift-card.jpg',
        descricao: 'Gift Card Xbox Ultimate Game Pass 3 meses.',
        valor_real: 'R$ 89,00',
        valor_desconto: 'R$ 60,00',
      },
      {
        imagem : 'assets/images/img-produtos/fliper.webp',
        descricao: 'Controle aecade The King of Fighter Player solo.',
        valor_real: 'R$ 1899,00',
        valor_desconto: 'R$ 1999,00',
      },
      {
        imagem : 'assets/images/img-produtos/joy-xbox.png',
        descricao: 'Controle Xbox One Series Tema Cyberpunk.',
        valor_real: 'R$ 630,00',
        valor_desconto: 'R$ 570,00',
      },
      {
        imagem : 'assets/images/img-produtos/monitor.png',
        descricao: 'Monitor Asus 4k 27".',
        valor_real: 'R$ 1590,00',
        valor_desconto: 'R$ 1300,00',
      },
    ]

    return of(arrayProdutos)
  }
}
