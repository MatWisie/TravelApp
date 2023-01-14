using TravelApp.Models;
using TravelApp.Stores;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class ChangeViewWannaGoCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public ChangeViewWannaGoCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new WannaGoViewModel(new CountryControlModel());
        }
    }
}
