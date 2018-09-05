using Xamarin.Forms;
using MobFlix.Core.ViewModels;

namespace MobFlix.Forms.Pages
{
    public class BasePage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is BaseViewModel viewModel)
            {
                viewModel.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (BindingContext is BaseViewModel viewModel)
            {
                viewModel.OnDisappearing();
            }
        }
    }
}
