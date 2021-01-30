using System.Threading.Tasks;

namespace LogYourself.ViewModels.Base
{
    public interface INavigationViewModel
    {
        string FullNavigationPath { get; set; }
        Task BeforeFirstShown();
        Task AfterDismissed();
    }
}