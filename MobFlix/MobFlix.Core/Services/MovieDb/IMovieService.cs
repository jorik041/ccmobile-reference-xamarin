using System.Threading.Tasks;
using Refit;
using MobFlix.Core.Models.Responses;

namespace MobFlix.Core.Services.MovieDb
{
    public interface IMovieService
    {
        [Get("/discover/movie?primary_release_date.gte=2018-05-01&primary_release_date.lte=2018-05-30")]
        Task<SearchResultResponse> GetAllInCinemaAsync();
    }
}
