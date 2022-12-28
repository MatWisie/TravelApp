using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Commands;
using TravelApp.Models;
using TravelApp.Views;

namespace TravelApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly MainWindowModel _mainWindowModel;
        public MainWindowViewModel(MainWindowModel mainWindowModel)
        {
            _mainWindowModel = mainWindowModel;
            currentView = new CountryViewModel();
            FillCombobox = new FillComboboxCommand(this, _mainWindowModel);
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
                return _mainWindowModel.CurrentView; 
            }
            set 
            { 
                _mainWindowModel.CurrentView = value;
                OnPropertyChanged(nameof(currentView));
            }
        }

        public ICommand FillCombobox { get; }
    }
}
