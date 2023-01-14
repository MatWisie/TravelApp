using System.Collections.ObjectModel;
using TravelApp.Models;

namespace TravelApp.Interfaces
{
    public interface IListOfModels
    {
        ObservableCollection<CountryControlModel> ListOfModels
        {
            get;
            set;
        }
    }
}
