using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobFlix.Forms.Pages;
using MobFlix.Core.ViewModels;
using MobFlix.Core.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobFlix.Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NowInCinemaPage() { BindingContext = new NowInCinemaViewModel(MovieDbServiceResolver.Resolve<IMovieService>()) };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
