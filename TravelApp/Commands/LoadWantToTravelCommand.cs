using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Models;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class LoadWantToTravelCommand : CommandBase
    {
        private readonly CountryControlModel _countryControlModel;
        WannaGoViewModel _viewModel;
        public LoadWantToTravelCommand(CountryControlModel countryControlModel, WannaGoViewModel viewModel)
        {
            _countryControlModel = countryControlModel;
            _viewModel = viewModel;
        }
        public override void Execute(object parameter)
        {
            List<CountryControlModel> tmpList = _countryControlModel.Load("WannaGo.json");
            foreach (var item in tmpList)
            {
                _viewModel.ListOfModels.Add(item);
            }
        }
    }
}
