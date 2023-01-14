using TravelApp.Models;
using TravelApp.Stores;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class ChangeViewWasThereCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public ChangeViewWasThereCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new WasThereViewModel(new CountryControlModel());
        }
    }
}
