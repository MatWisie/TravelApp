using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TravelApp.Stores;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class TestViewModelCommand : CommandBase
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        private readonly NavigationStore _navigationStore;
        private TravelApp.App currentApp = Application.Current as App;
        public TestViewModelCommand(NavigationStore navigationStore, MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            _navigationStore = navigationStore;
        }
        public override void Execute(object parameter)
        {
            //currentApp.searchedCountry = _mainWindowViewModel.comboboxCountry.Name;
            _navigationStore.CurrentViewModel = new TestViewModel();
        }
    }
}
