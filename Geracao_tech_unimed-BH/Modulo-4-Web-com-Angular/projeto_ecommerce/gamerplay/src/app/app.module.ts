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
