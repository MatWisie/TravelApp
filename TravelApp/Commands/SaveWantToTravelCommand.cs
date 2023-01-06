using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Models;

namespace TravelApp.Commands
{
    public class SaveWantToTravelCommand : CommandBase
    {
        CountryControlModel _countryControlModel;
        public SaveWantToTravelCommand(CountryControlModel countryControlModel)
        {
            _countryControlModel = countryControlModel;
        }
        public override void Execute(object parameter)
        {
            _countryControlModel.Save("WannaGo.json");
        }
    }
}
