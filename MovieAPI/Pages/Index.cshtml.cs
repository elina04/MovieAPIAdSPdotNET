using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieAPI.Models;
using MovieAPI.Services;

namespace MovieAPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileMovieService MovieService { get; set; }

        public IEnumerable<Movie> Movies { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileMovieService jsonFileMovieService)
        {
            _logger = logger;
            this.MovieService = jsonFileMovieService;
        }

        public void OnGet()
        {
            this.Movies = MovieService.GetMovies();
        }
    }
}