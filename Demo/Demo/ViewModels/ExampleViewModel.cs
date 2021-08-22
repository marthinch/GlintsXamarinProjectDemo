using Demo.Services;
using Demo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo.ViewModels
{
    public class ExampleViewModel : INotifyPropertyChanged
    {
        protected bool SetProperty<T>(ref T backingStore,
                                      T value,
                                      [CallerMemberName] string propertyName = "",
                                      Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
            {
                return false;
            }

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string description;
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public ICommand BukaHalamanCommand => new Command(async () => await BukaHalamanBerikutnya());

        private INavigationService NavigationService { get; }

        public ExampleViewModel()
        {
            NavigationService = ServiceContainer.Resolution<INavigationService>();
        }

        private async Task BukaHalamanBerikutnya()
        {
            //string description = "Ini adalah data dari halaman example";

            await NavigationService.PushAsync(new Halaman1(Description));
        }
    }
}
