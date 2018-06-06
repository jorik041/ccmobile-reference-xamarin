using Refit;

namespace MobFlix.Core.Services
{
    public static class MovieDbServiceResolver
    {
        private const string _imageBaseUrl = "https://image.tmdb.org/t/p/w185/";
        private const string _apiKey = "61847937aad8c2a54376001ce143f6cb";
        private const string _baseUrl = "https://api.themoviedb.org/3";

        public static T Resolve<T>()
        {
            return RestService.For<T>(_baseUrl);
        }
    }
}
