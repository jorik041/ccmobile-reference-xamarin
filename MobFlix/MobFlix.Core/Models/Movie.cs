using System;
using System.Collections.Generic;
using MobFlix.Core.Services;
using MobFlix.Core.Services.MovieDb;
using Newtonsoft.Json;

namespace MobFlix.Core.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }
        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }
        [JsonProperty("genre_ids")]
        public List<int> GenreIds { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonIgnore]
        public string FullPosterPath => MovieDbServiceProvider.ImageBaseUrl + PosterPath;
    }
}
