import { Component, OnInit } from '@angular/core';
import { ListaProdutosService } from '../../servicos/produtos/lista-produtos.service';

@Component({
  selector: 'app-card-produto',
  templateUrl: './card-produto.component.html',
  styleUrls: ['./card-produto.component.css']
})
export class CardProdutoComponent implements OnInit {

  produtos = [
    {
      imagem : '',
      descricao: '',
      valor_real: '',
      valor_desconto: '',
    }
  ]

  constructor(private listaProdutosService: ListaProdutosService) { }

  ngOnInit(): void {
    this.getProdutos()
  }

  getProdutos(){
    this.listaProdutosService.getProdutos().subscribe(produto =>{
      this.produtos = produto
    })
  }

}
