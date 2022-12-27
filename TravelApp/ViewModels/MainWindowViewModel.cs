using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public string date
        {
            get { return _mainWindowModel.Date; }
        }
        public List<CountryNameModel> countries
        {
            get { return _mainWindowModel.Countries; }
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
    }
}
