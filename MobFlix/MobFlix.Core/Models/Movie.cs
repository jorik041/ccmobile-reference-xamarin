using System;
using System.Collections.Generic;
namespace MobFlix.Core.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public int VoteCount { get; set; }
        public string PosterPath { get; set; }
        public List<int> GenreIds { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
