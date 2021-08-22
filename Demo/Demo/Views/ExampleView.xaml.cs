using Demo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleView : ContentPage
    {
        public ExampleView()
        {
            InitializeComponent();

            BindingContext = new ExampleViewModel();
        }
    }
}