using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace MobFlix.Core.Models.Responses
{
    public class SearchResultResponse
    {
        public int Page { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results")]
        public Movie[] Movies { get; set; }
    }
}
