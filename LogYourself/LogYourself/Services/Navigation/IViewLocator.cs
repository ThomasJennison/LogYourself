using LogYourself.ViewModels.Base;
using Xamarin.Forms;

namespace LogYourself.Services.Navigation
{
    public interface IViewLocator
    {
        Page CreateAndBindPageFor<TViewModel>(TViewModel viewModel) where TViewModel : INavigationViewModel;
    }
}
