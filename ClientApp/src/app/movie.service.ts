import { Injectable } from '@angular/core';
import { Observable} from 'rxjs';
import { of } from 'rxjs/observable/of';
import { Movie } from './Movie'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, tap } from 'rxjs/operators';

const httpOptions = {
  headers: new HttpHeaders({'Content-Type':'application/json'})
};
@Injectable()




export class MovieService {
  private Url = 'https://webapplication420181211022930.azurewebsites.net/';

  private api = 'api/Movies';
  private moviesURL = 'api/MoviesLists';
  constructor(private http: HttpClient) { }

  getMovieFromTitle(title: string): Observable<Movie>{

    return this.http.get<Movie>(this.Url + this.api + "/" + title).pipe(
      tap(_=> console.log(`sent a get request with title ${title}`)),
      catchError(this.handleError<Movie>(`getMovie if = ${title}`))
    )

  }

  getAll(): Observable<Movie[]>{
    return this.http.get<Movie[]>(this.Url + this.api).pipe(
      tap(_=> console.log(`sent a get request with title `)),
      catchError(this.handleError<Movie[]>(`getMovie if`))
    )
  }

  addMovieToList(movie: string): Observable<string>{
    return this.http.post<string>(this.moviesURL, movie, httpOptions)
      .pipe(
        catchError(this.handleError('addHero', movie))
      );
  }



  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
  
      // TODO: better job of transforming error for user consumption
  //   this.log(`${operation} failed: ${error.message}`);
  
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
