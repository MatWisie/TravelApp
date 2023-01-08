using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Interfaces;
using TravelApp.Models;

namespace TravelApp.ViewModels
{
    public class WasThereViewModel : ViewModelBase, IListOfModels
    {
        private readonly CountryControlModel _countryControlModel;

        public WasThereViewModel(CountryControlModel countryControlModel)
        {
            _countryControlModel = countryControlModel;
        }
        private ObservableCollection<CountryControlModel> _listOfModels = new ObservableCollection<CountryControlModel>();

        public ObservableCollection<CountryControlModel> ListOfModels
        {
            get { return _listOfModels; }
            set
            {
                _listOfModels = value;
                OnPropertyChanged(nameof(ListOfModels));
            }
        }

        public ICommand LoadWasThere { get; }
    }
}
