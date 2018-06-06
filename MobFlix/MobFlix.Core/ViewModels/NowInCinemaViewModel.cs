using System.Collections.Generic;
using MobFlix.Core.Models;
using System.Threading.Tasks;
using MobFlix.Core.Services;
using System.Linq;
using System.Collections.ObjectModel;

namespace MobFlix.Core.ViewModels
{
    public class NowInCinemaViewModel : BaseViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; }

        private readonly IMovieService _movieService;
        public NowInCinemaViewModel(IMovieService movieService)
        {
            _movieService = movieService;
            Movies = new ObservableCollection<Movie>();
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            await GetMovies();
        }

        public async Task GetMovies()
        {
            var searchResult = await _movieService.GetAllInCinemaAsync();
            if (searchResult != null)
            {
                // TODO: improve
                foreach(var movie in searchResult.Movies)
                {
                    Movies.Add(movie);
                }
            }
        }
    }
}
