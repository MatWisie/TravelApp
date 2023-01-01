using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using TravelApp.Models;
using TravelApp.Stores;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class SelectCountryCommand : CommandBase
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        private readonly NavigationStore _navigationStore;
        private TravelApp.App currentApp = Application.Current as App;
        private CountryViewModel _countryViewModel;
        private CountryControlModel _countryControlModel;
        public SelectCountryCommand(NavigationStore navigationStore, MainWindowViewModel mainWindowViewModel, CountryControlModel countryControlModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            _navigationStore = navigationStore;
            _countryControlModel = countryControlModel;
            _countryViewModel = new CountryViewModel(_countryControlModel);
        }
        public override async void Execute(object parameter)
        {
            //_countryViewModel = new CountryViewModel(_countryControlModel);
            currentApp.searchedCountry = _mainWindowViewModel.comboboxCountry.Name;

            CountryModel tmp;
            _countryControlModel.Name = currentApp.searchedCountry;
            tmp = await _countryControlModel.LoadCountry();

            _countryViewModel.name = tmp.Name;
            _countryViewModel.nativeName = tmp.NativeName;
            _countryViewModel.capital = tmp.Capital;
            _countryViewModel.region = tmp.Region;
            _countryViewModel.population = tmp.Population;
            _countryViewModel.area = tmp.Area;
            _countryViewModel.flag = tmp.Flags.png;
            _countryViewModel.currencies = tmp.Currencies;

            _navigationStore.CurrentViewModel = _countryViewModel;
            //new TestViewModel();
        }
    }
}
