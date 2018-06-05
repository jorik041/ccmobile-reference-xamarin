using System.Collections.Generic;
using MobFlix.Core.Models;
using System.Threading.Tasks;
using Refit;
using MobFlix.Core.Services;

namespace MobFlix.Core.ViewModels
{
    public class NowInCinemaViewModel : BaseViewModel
    {
        private List<Movie> _movies = new List<Movie>();
        public List<Movie> Movies 
        { 
            get{ return _movies; } 
            set
            {
                _movies = value;
                RaisePropertyChanged();
            } 
        } 
       
        public async Task LoadAsync()
        {
            // TODO: replace with baseUrl
            var movieService = RestService.For<IMovieService>("");
            Movies = await movieService.GetAllInCinemaAsync().ConfigureAwait(false);
        }
    }
}
