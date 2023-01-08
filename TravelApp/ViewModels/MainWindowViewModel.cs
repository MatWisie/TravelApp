using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Commands;
using TravelApp.Models;
using TravelApp.Stores;
using TravelApp.Views;

namespace TravelApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly MainWindowModel _mainWindowModel;
        private readonly NavigationStore _navigationStore;
        public MainWindowViewModel(MainWindowModel mainWindowModel, NavigationStore navigationStore)
        {
            _mainWindowModel = mainWindowModel;
            FillCombobox = new FillComboboxCommand(this, _mainWindowModel);
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            SelectCountry = new SelectCountryCommand(_navigationStore, this, new CountryControlModel());
            ChangeViewWannaGo = new ChangeViewWannaGoCommand(_navigationStore);
            ChangeViewWasThere = new ChangeViewWasThereCommand(_navigationStore);
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(currentView));
        }

        public string date
        {
            get { return _mainWindowModel.Date; }
        }
        public ObservableCollection<CountryNameModel> countries
        {
            get 
            { 
                return _mainWindowModel.Countries; 
            }
            set 
            {
                _mainWindowModel.Countries = value;
                OnPropertyChanged(nameof(countries));
            }

        }
        public ViewModelBase currentView
        {
            get 
            {
                return _navigationStore.CurrentViewModel;
            }
            set 
            {
                _navigationStore.CurrentViewModel = value;
                OnPropertyChanged(nameof(currentView));
            }
        }

        private CountryNameModel _comboboxCountry;
        public CountryNameModel comboboxCountry
        {
            get 
            {
                return _comboboxCountry; 
            }
            set 
            {
                _comboboxCountry = value;
                OnPropertyChanged(nameof(comboboxCountry)); 
            }
        }

        public ICommand FillCombobox { get; }
        public ICommand SelectCountry { get; }
        public ICommand ChangeViewWannaGo { get; }
        public ICommand ChangeViewWasThere { get; }
    }
}
