import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './component/shared/header/header.component';
import { FooterComponent } from './component/shared/footer/footer.component';
import { LogoComponent } from './component/shared/header/logo/logo.component';
import { MenuComponent } from './component/shared/header/menu/menu.component';
import { ServicosComponent } from './component/shared/header/servicos/servicos.component';
import { BuscaComponent } from './component/shared/header/busca/busca.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatExpansionModule} from '@angular/material/expansion';
import { UsuarioComponent } from './component/shared/header/servicos/usuario/usuario.component';
import { FavoritosComponent } from './component/shared/header/servicos/favoritos/favoritos.component';
import { CarrinhoComponent } from './component/shared/header/servicos/carrinho/carrinho.component';
import { AsideComponent } from './component/aside/aside.component';
import { AreaBannerComponent } from './component/area-banner/area-banner.component';
import { AreaOfertasComponent } from './component/area-ofertas/area-ofertas.component';
import { DestaqueComponent } from './component/area-ofertas/destaque/destaque.component';
import { OfertaFimSemanaComponent } from './component/area-ofertas/oferta-fim-semana/oferta-fim-semana.component';
import { BotoesComponent } from './component/shared/itens/botoes/botoes.component';
import { ComprarComponent } from './component/shared/itens/botoes/comprar/comprar.component';
import { EstrelasComponent } from './component/shared/itens/estrelas/estrelas.component';
import { IndicadoresComponent } from './component/shared/itens/indicadores/indicadores.component';
import { MaisVendidosComponent } from './component/mais-vendidos/mais-vendidos.component';
import { CardProdutoComponent } from './component/mais-vendidos/card-produto/card-produto.component';
import { AddCarrinhoComponent } from './component/servicos/add-carrinho/add-carrinho.component';
import { MarcasComponent } from './component/marcas/marcas.component';
import { BoletimComponent } from './component/shared/footer/boletim/boletim.component';
import { SociaisComponent } from './component/shared/footer/sociais/sociais.component';
import { MenuFooterComponent } from './component/shared/footer/menu-footer/menu-footer.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    LogoComponent,
    MenuComponent,
    ServicosComponent,
    BuscaComponent,
    UsuarioComponent,
    FavoritosComponent,
    CarrinhoComponent,
    AsideComponent,
    AreaBannerComponent,
    AreaOfertasComponent,
    DestaqueComponent,
    OfertaFimSemanaComponent,
    BotoesComponent,
    ComprarComponent,
    EstrelasComponent,
    IndicadoresComponent,
    MaisVendidosComponent,
    CardProdutoComponent,
    AddCarrinhoComponent,
    MarcasComponent,
    BoletimComponent,
    SociaisComponent,
    MenuFooterComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatExpansionModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
