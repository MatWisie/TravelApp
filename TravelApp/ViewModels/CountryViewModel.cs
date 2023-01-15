using System;
using System.Collections.Generic;
using System.Windows.Input;
using TravelApp.Commands;
using TravelApp.Enums;
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
            SaveWantToTravel = new SaveCountryCommand(_countryControlModel, "WannaGo.json");
            SaveWasThere = new SaveCountryCommand(_countryControlModel, "WasThere.json");
            ChangeMode = new ChangeModeCommand(this);
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

        public List<LanguageModel> languages
        {
            get { return _countryControlModel.Languages; }
            set { _countryControlModel.Languages = value; }
        }

        private bool _dateGridState = false;
        public bool dateGridState
        {
            get
            {
                return _dateGridState;
            }
            set
            {
                _dateGridState = value;
                OnPropertyChanged(nameof(dateGridState));
            }
        }

        private AddModeEnum _addMode;
        public AddModeEnum addMode
        {
            get
            {
                return _addMode;
            }
            set
            {
                _addMode = value;
                if(value == AddModeEnum.WannaGo) 
                {
                    modeString = "Want to go";
                }
                else if(value == AddModeEnum.WasThere) 
                {
                    modeString = "Was there";
                }
                OnPropertyChanged(nameof(addMode));
            }
        }

        public DateTime? fromDate 
        {
            get
            {
                return _countryControlModel.FromDate;
            }
            set
            {
                _countryControlModel.FromDate = value;
                OnPropertyChanged(nameof(fromDate));
            }
        }
        public DateTime? toDate
        {
            get
            {
                return _countryControlModel.ToDate;
            }
            set
            {
                _countryControlModel.ToDate = value;
                OnPropertyChanged(nameof(toDate));
            }
        }
        private string _modeString;
        public string modeString 
        {
            get 
            { 
                return _modeString; 
            }
            set 
            { 
                _modeString = value; 
                OnPropertyChanged(nameof(modeString)); 
            }
        }

        public ICommand ShowCountry { get; }
        public ICommand SaveWantToTravel { get; }
        public ICommand SaveWasThere { get; }
        public ICommand ChangeMode { get; }
        private ICommand _SaveCountry;
        public ICommand SaveCountry
        {
            get
            {
                return _SaveCountry;
            }
            set
            {
                _SaveCountry = value;
                OnPropertyChanged(nameof(SaveCountry));
            }
        }
    }
}
