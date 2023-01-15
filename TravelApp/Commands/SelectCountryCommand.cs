using System;
using System.Windows;
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
            try
            {
                currentApp.searchedCountry = _mainWindowViewModel.comboboxCountry.Name;
                CountryModel tmp;
                _countryControlModel.Name = currentApp.searchedCountry;
                tmp = await _countryControlModel.LoadCountry();
                _countryViewModel.name = tmp.Name;
                _countryViewModel.nativeName = tmp.NativeName;
                _countryViewModel.capital = tmp.Capital;
                _countryViewModel.region = tmp.Region;
                _countryViewModel.population = tmp.Population;
                _countryViewModel.numericCode = tmp.NumericCode;
                _countryViewModel.area = tmp.Area;
                _countryViewModel.flag = tmp.Flags.png;
                _countryViewModel.currencies = tmp.Currencies;
                _countryViewModel.languages = tmp.Languages;
                _countryViewModel.dateGridState = false;
                _navigationStore.CurrentViewModel = _countryViewModel;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Such a country does not exist or is not in our database");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
