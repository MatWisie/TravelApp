using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Models;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class DeleteSelectedWannaGoCommand : CommandBase
    {
        private readonly WannaGoViewModel _viewModel;
        private readonly CountryControlModel _countryControlModel;
        public DeleteSelectedWannaGoCommand(CountryControlModel countryControlModel,WannaGoViewModel viewModel)
        {
            _viewModel = viewModel;
            _countryControlModel = countryControlModel;
        }
        public override void Execute(object parameter)
        {
            _viewModel.ListOfModels.Remove(_viewModel.ListOfModels.Where(a => a.Index == (int)parameter).SingleOrDefault());
            List<CountryControlModel> tmpList = new List<CountryControlModel>();
            foreach(var item in _viewModel.ListOfModels) 
            {
                tmpList.Add(item);
            }
            _countryControlModel.Save("WannaGo.json", tmpList);
        }
    }
}
