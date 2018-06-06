using System.Threading.Tasks;
using Refit;
using MobFlix.Core.Models.Responses;

namespace MobFlix.Core.Services
{
    public interface IMovieService
    {
        [Get("discover/movie?primary_release_date.gte=2018-05-01&primary_release_date.lte=2018-05-30&api_key=61847937aad8c2a54376001ce143f6cb")]
        Task<SearchResultResponse> GetAllInCinemaAsync();
    }
}
