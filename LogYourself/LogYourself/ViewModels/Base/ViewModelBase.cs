using LogYourself.Services;
using Splat;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LogYourself.ViewModels.Base
{
    public class ViewModelBase : PropertyChangedBase
    {

        protected readonly IDatabaseService _database;

        public Command BackCommand { get; private set; }
        public Command HomeCommand { get; private set; }

        public string FullNavigationPath { get; set; }

        public ViewModelBase(IDatabaseService db = null)
        {
            _database = db ?? (IDatabaseService)Locator.Current.GetService(typeof(IDatabaseService));
        }

        public Task BeforeFirstShown()
        {
            return Task.CompletedTask;
        }

        public Task AfterDismissed()
        {
            return Task.CompletedTask;
        }

    }
}
