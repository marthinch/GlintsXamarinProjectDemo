using Demo.Models;
using Demo.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private Login login { get; } = new Login();

        private string username;
        public string Username
        {
            get => username;
            set
            {
                SetProperty(ref username, value);

                IsUsernameError = string.IsNullOrEmpty(Username);
            }
        }

        private bool isUsernameError;
        public bool IsUsernameError
        {
            get => isUsernameError;
            set => SetProperty(ref isUsernameError, value);
        }

        private string password;
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public ICommand MasukCommand => new Command(async () => await MasukAsync());

        public LoginViewModel()
        {
            
        }

        private async Task MasukAsync()
        {
            await NavigationService.PushAsync(new Halaman1());
        }
    }
}
