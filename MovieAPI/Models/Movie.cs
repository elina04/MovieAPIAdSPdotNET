using System.Text.Json;
using System.Text.Json.Serialization;

namespace MovieAPI.Models
{
    public class Movie
    {
        public string? Title { get; set; }
        public string? Year { get; set; }
        [JsonPropertyName("imdbID")]
        public string? ImdbID { get; set; }
        public string? Type { get; set; }
        [JsonPropertyName("Poster")]
        public string? PosterURL { get; set;}

        public override string ToString() => JsonSerializer.Serialize<Movie>(this);

    }
}
