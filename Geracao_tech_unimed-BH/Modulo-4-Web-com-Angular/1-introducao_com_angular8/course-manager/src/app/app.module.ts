import { Component, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CourseListComponent } from './couser/couser-list.components';
import { StarComponent } from './star/star.component';
import { ReplecePipe } from './pipe/replece.pipe';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { Erro404Component } from './erro-404/erro-404.component';

@NgModule({
  declarations: [
    AppComponent,
    CourseListComponent,
    StarComponent,
    ReplecePipe,
    NavBarComponent,
    Erro404Component
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([
      {
        path: '', redirectTo: 'course', pathMatch: 'full'
      },
      {
        path: 'course', component: CourseListComponent
      },
      {
        path: '**', component: Erro404Component
      }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
