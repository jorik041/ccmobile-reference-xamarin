using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MobFlix.Core.ViewModels
{
    public class BaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void OnAppearing() {}

        public virtual void OnDisappearing() {}
    }
}
