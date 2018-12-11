import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { MovieDetailComponent } from './movie-detail/movie-detail.component';
import { MovieService } from './movie.service';
import { AllMoviesComponent } from './all-movies/all-movies.component';
import { AuthService } from './auth.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MovieDetailComponent,
    AllMoviesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: AllMoviesComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'moviedetails/:movieid', component: MovieDetailComponent },
      { path: 'callback', component: HomeComponent },
    ])
  ],
  providers: [MovieService,AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
