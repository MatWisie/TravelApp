using System.Collections.ObjectModel;
using System.Windows.Input;
using TravelApp.Commands;
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
            LoadWasThere = new LoadCountryCommand(_countryControlModel, this, "WasThere.json");
            DeleteSelectedWasThere = new DeleteSelectedCountryCommand(_countryControlModel, this, "WasThere.json");
            SaveWasThere = new SaveCountryCommand(_countryControlModel, "WasThere.json", ListOfModels);
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
        public ICommand DeleteSelectedWasThere { get; }
        public ICommand SaveWasThere { get; }
    }
}
