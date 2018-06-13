using Refit;
using System.Net.Http;
using System;

namespace MobFlix.Core.Services.MovieDb
{
    public static class MovieDbServiceProvider
    {
        public const string ImageBaseUrl = "https://image.tmdb.org/t/p/w185/";
        public const string ApiKey = "61847937aad8c2a54376001ce143f6cb";
        private const string _baseUrl = "https://api.themoviedb.org/3";

        public static T Resolve<T>()
        {
            return RestService.For<T>(new HttpClient(new MovieDbServiceClientHandler()) { BaseAddress = new Uri(_baseUrl) });
        }
    }
}
