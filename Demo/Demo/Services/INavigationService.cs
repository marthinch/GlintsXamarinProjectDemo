using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo.Services
{
    public interface INavigationService
    {
        Task PushAsync(Page page, bool animate = true);
        Task PopAsync(bool animate = true);
        Task PushModalAsync(Page page, bool animate = true);
        Task PopModalAsync(bool animate = true);
    }
}
