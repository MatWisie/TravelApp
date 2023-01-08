using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using TravelApp.Commands;
using TravelApp.Models;

namespace TravelApp.ViewModels
{
    public class CountryViewModel : ViewModelBase
    {
        private readonly CountryControlModel _countryControlModel;
        public CountryViewModel(CountryControlModel countryControlModel)
        {
            _countryControlModel = countryControlModel;
            ShowCountry = new ShowCountryCommand(this, _countryControlModel);
            SaveWantToTravel = new SaveWantToTravelCommand(_countryControlModel, "WannaGo.json");
        }

        public string name
        {
            get
            {
                return _countryControlModel.Name;
            }
            set
            {
                _countryControlModel.Name = value;
                OnPropertyChanged(nameof(name));
            }
        }
        public string nativeName 
        {
            get
            {
                return _countryControlModel.NativeName;
            }
            set 
            {
                _countryControlModel.NativeName = value;
                OnPropertyChanged(nameof(nativeName));
            }
        }

        public string capital
        {
            get 
            { 
                return _countryControlModel.Capital; 
            }
            set
            {
                _countryControlModel.Capital = value;
                OnPropertyChanged(nameof(capital));
            }
        }

        public string region 
        {
            get 
            { 
                return _countryControlModel.Region; 
            }
            set
            {
                _countryControlModel.Region = value;
                OnPropertyChanged(nameof(region));
            }
        }
        public int population
        {
            get 
            { 
                return _countryControlModel.Population; 
            }
            set
            {
                _countryControlModel.Population = value;
                OnPropertyChanged(nameof(population));
            }
        }
        public double area
        {
            get 
            { 
                return _countryControlModel.Area; 
            }
            set
            {
                _countryControlModel.Area = value;
                OnPropertyChanged(nameof(area));
            }
        }
        public string numericCode
        {
            get 
            { 
                return _countryControlModel.NumericCode; 
            }
            set
            {
                _countryControlModel.NumericCode = value;
                OnPropertyChanged(nameof(numericCode));
            }
        }
        public string flag 
        {
            get 
            { 
                return _countryControlModel.Flags;
            }
            set
            {
                _countryControlModel.Flags = value;
                OnPropertyChanged(nameof(flag));
            }
        }
        public List<CurrencyModel> currencies
        {
            get
            {
                return _countryControlModel.Currencies;
            }
            set
            {
                _countryControlModel.Currencies = value;
                OnPropertyChanged(nameof(currencies));
            }
        }

        public ICommand ShowCountry { get; set; }
        public ICommand SaveWantToTravel { get; set; }
    }
}
