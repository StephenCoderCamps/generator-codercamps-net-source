namespace MyApp.Controllers {

    export class HomeController {
        public movies;

        constructor(movieService:MyApp.Services.MovieService) {
            this.movies = movieService.listMovies();
        }
    }

}