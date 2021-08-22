using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Halaman1 : ContentPage
    {
        public Halaman1(string description = null)
        {
            InitializeComponent();

            labelDescription.Text = description;
        }
    }
}