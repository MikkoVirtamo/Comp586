import { Component, OnInit } from '@angular/core';
import {Movie} from '../Movie'
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-all-movies',
  templateUrl: './all-movies.component.html',
  styleUrls: ['./all-movies.component.css']
})
export class AllMoviesComponent implements OnInit {

  moviesList: Movie[];
  constructor(private movieservice: MovieService) { 
    
  }

  getMovies(): void{
    this.movieservice.getAll().subscribe(moviesList => this.moviesList = moviesList);
  }

  ngOnInit() {
    this.getMovies();
  }

}
