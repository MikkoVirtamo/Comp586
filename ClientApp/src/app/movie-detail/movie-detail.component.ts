import { Component, OnInit } from '@angular/core';
import { Movie } from '../Movie'
import { MovieService } from '../movie.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrls: ['./movie-detail.component.css']
})
export class MovieDetailComponent implements OnInit {
movieToDisplay: Movie;
 movie: string;
  constructor(private route: ActivatedRoute,
    private movieService: MovieService) { }

    ngOnInit() {
      this.getMovie();
      
      }
    
      add(){

      }
      
      getMovie(): void {
        //movie: string;
        this.movie=this.route.snapshot.paramMap.get('movieid');
       //movie: String; = +this.route.snapshot.paramMap.get('movieid');
       console.log("The movie sent in the get request is " + this.movie);
        this.movieService.getMovieFromTitle(this.movie)
        .subscribe(movieToDisplay => this.movieToDisplay = movieToDisplay);
        
      }

}
