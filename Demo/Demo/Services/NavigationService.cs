using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo.Services
{
    public class NavigationService : INavigationService
    {
        public async Task PopAsync(bool animate = true)
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        public async Task PopModalAsync(bool animate = true)
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        }

        public async Task PushAsync(Page page, bool animate = true)
        {
            await App.Current.MainPage.Navigation.PushAsync(page, animate);
        }

        public async Task PushModalAsync(Page page, bool animate = true)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(page, animate);
        }
    }
}
