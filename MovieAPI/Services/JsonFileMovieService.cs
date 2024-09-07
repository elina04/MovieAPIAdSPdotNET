using MovieAPI.Models;
using System.Text.Json;

namespace MovieAPI.Services
{
    public class JsonFileMovieService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "movies.json");

        public JsonFileMovieService(IWebHostEnvironment webHostEnvironment)
        {
            this.WebHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Movie> GetMovies()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            var jsonStr = jsonFileReader.ReadToEnd();
            var json = JsonSerializer.Deserialize<Movie[]>(jsonStr,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return json;
        }
    }
}
