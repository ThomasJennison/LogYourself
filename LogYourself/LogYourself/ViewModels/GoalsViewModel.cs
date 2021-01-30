using LogYourself.ViewModels.Base;

namespace LogYourself.ViewModels
{
    public class GoalsViewModel : ViewModelBase, INavigationViewModel
    {
        public const string NavigationNodeName = "goals";

        public GoalsViewModel()
        {
        }
    }
}
