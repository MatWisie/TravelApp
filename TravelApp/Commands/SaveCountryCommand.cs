using TravelApp.Models;

namespace TravelApp.Commands
{
    public class SaveCountryCommand : CommandBase
    {
        private readonly CountryControlModel _countryControlModel;
        private string _fileName;
        public SaveCountryCommand(CountryControlModel countryControlModel, string fileName)
        {
            _countryControlModel = countryControlModel;
            _fileName = fileName;
        }
        public override void Execute(object parameter)
        {
            _countryControlModel.Save(_fileName);
        }
    }
}
