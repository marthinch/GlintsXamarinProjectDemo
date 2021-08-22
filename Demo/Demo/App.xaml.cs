using Demo.Services;
using Demo.Views;
using Xamarin.Forms;

namespace Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RegisterService();
        }

        private void RegisterService()
        {
            ServiceContainer.Register<INavigationService>(() => new NavigationService());
        }

        protected override void OnStart()
        {
            //MainPage = new ExampleView();
            //MainPage = new NavigationPage(new ExampleView());
            MainPage = new NavigationPage(new LoginView());
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
