using System.Collections.Generic;
using System.Collections.ObjectModel;
using TravelApp.Models;

namespace TravelApp.Commands
{
    public class SaveCountryCommand : CommandBase
    {
        private readonly CountryControlModel _countryControlModel;
        private string _fileName;
        private ObservableCollection<CountryControlModel> _data;
        public SaveCountryCommand(CountryControlModel countryControlModel, string fileName)
        {
            _countryControlModel = countryControlModel;
            _fileName = fileName;
        }

        public SaveCountryCommand(CountryControlModel countryControlModel, string fileName, ObservableCollection<CountryControlModel> data)
        {
            _countryControlModel = countryControlModel;
            _fileName = fileName;
            _data = data;
        }
        public override void Execute(object parameter)
        {
            if(_data == null)
                _countryControlModel.Save(_fileName);
            else
            {
                List<CountryControlModel> tmpList = new List<CountryControlModel>();
                foreach (var item in _data)
                {
                    tmpList.Add(item);
                }
                _countryControlModel.Save(_fileName, tmpList);
            }
        }
    }
}
