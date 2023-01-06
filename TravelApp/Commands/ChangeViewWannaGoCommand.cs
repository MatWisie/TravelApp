using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
