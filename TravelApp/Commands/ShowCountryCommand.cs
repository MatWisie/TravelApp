using System.Windows;
using TravelApp.Models;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class ShowCountryCommand : CommandBase
    {
        private readonly CountryControlModel _countryControlModel;
        private readonly CountryViewModel _countryViewModel;
        private TravelApp.App currentApp = Application.Current as App;
        public ShowCountryCommand(CountryViewModel countryViewModel, CountryControlModel countryControlModel)
        {
            _countryControlModel = countryControlModel;
            _countryViewModel = countryViewModel;
        }
        public override bool CanExecute(object parameter)
        {
            if (currentApp.searchedCountry != null)
                return true;
            else
                return false;
        }
        public override async void Execute(object parameter)
        {
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
            

        }
    }
}
