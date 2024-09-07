using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Services;

namespace MovieAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public JsonFileMovieService MovieService { get; }

        public MovieController(JsonFileMovieService jfms)
        {
                MovieService = jfms;
        }
        
        [HttpGet]
        public IEnumerable<Movie> Get() {
            return MovieService.GetMovies();
        }
    }
}
