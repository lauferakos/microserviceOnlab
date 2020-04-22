import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { MatToolbarModule, MatButtonModule, MatIconModule, MatFormFieldModule, MatInputModule, MatTableModule, MatCardModule} from '@angular/material';


import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavbarComponent } from './navbar/navbar.component';
import { SearchComponent } from './search/search.component';
import { FilmListComponent } from './film-list/film-list.component';
import { FilmDetailsComponent } from './film-details/film-details.component';
import { OrderListComponent } from './order-list/order-list.component';
import { ProjectionListComponent } from './projection-list/projection-list.component';
import { BasketComponent } from './basket/basket.component';
import { FilmService } from './services/film.service';
import { OrderService } from './services/order.service';
import { ProjectionService } from './services/projection.service';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    SearchComponent,
    FilmListComponent,
    FilmDetailsComponent,
    OrderListComponent,
    ProjectionListComponent,
    BasketComponent,
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatFormFieldModule,
    MatInputModule,
    MatTableModule,
    MatCardModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: FilmListComponent, pathMatch: 'full' },
      { path: 'orders', component: OrderListComponent },
      { path: 'projections', component: ProjectionListComponent },
      { path: 'basket', component: BasketComponent },
    ]),
    BrowserAnimationsModule
  ],
  providers: [FilmService, OrderService, ProjectionService],
  bootstrap: [AppComponent]
})
export class AppModule { }
