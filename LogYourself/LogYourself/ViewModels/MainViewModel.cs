using LogYourself.ViewModels.Base;
using LogYourself.ViewModels.Logs;
using System;

using System.IO;

using Xamarin.Forms;

using LogYourself.Pages;
using System.Threading.Tasks;


namespace LogYourself.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Command ToggleLogVisibilityCommand { get; set; }

        private bool _logVisibility;

        public bool LogVisibility
        {
            get => _logVisibility;
            set
            {
                if (_logVisibility == value)
                    return;

                _logVisibility = value;
                NotifyPropertyChanged();
            }
        }

        public MainViewModel()   
        {
            ToggleLogVisibilityCommand = new Command(() => ToggleLogVisibility());
        }

        public void ToggleLogVisibility()
        {
            LogVisibility = !LogVisibility;
        }
    }
}
