using MobFlix.Core.Models;
using System.Threading.Tasks;
using MobFlix.Core.Services;
using System.Collections.Generic;
using System.Linq;

namespace MobFlix.Core.ViewModels
{
    public class NowInCinemaViewModel : BaseViewModel
    {
        private List<Movie> _movies;
        public List<Movie> Movies
        {
            get { return _movies; }
            set
            {
                _movies = value;
                RaisePropertyChanged();
            }
        }
      
        private readonly IMovieService _movieService;
        public NowInCinemaViewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            await GetMoviesAsync();
        }

        public async Task GetMoviesAsync()
        {
            var searchResult = await _movieService.GetAllInCinemaAsync();
            if (searchResult.Movies != null)
            {
                Movies = searchResult.Movies.ToList();
            }
        }
    }
}
