using System;
using System.Collections.Generic;
namespace MobFlix.Core.Models.Responses
{
    public class SearchResultResponse
    {
        public int Page { get; set; }
        public int TotalResults { get; set; }
        public int TotalPages { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
