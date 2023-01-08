using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
