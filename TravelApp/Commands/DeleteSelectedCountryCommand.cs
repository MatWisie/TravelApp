using System.Collections.Generic;
using System.Linq;
using TravelApp.Interfaces;
using TravelApp.Models;

namespace TravelApp.Commands
{
    public class DeleteSelectedCountryCommand : CommandBase
    {
        private readonly IListOfModels _viewModel;
        private readonly CountryControlModel _countryControlModel;
        private string _fileName;
        public DeleteSelectedCountryCommand(CountryControlModel countryControlModel,IListOfModels viewModel, string fileName)
        {
            _viewModel = viewModel;
            _countryControlModel = countryControlModel;
            _fileName = fileName;
        }
        public override void Execute(object parameter)
        {
            _viewModel.ListOfModels.Remove(_viewModel.ListOfModels.Where(a => a.Index == (int)parameter).SingleOrDefault());
            List<CountryControlModel> tmpList = new List<CountryControlModel>();
            foreach(var item in _viewModel.ListOfModels) 
            {
                tmpList.Add(item);
            }
            _countryControlModel.Save(_fileName, tmpList);
        }
    }
}
