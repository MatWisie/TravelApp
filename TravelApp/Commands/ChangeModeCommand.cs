using TravelApp.Enums;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class ChangeModeCommand : CommandBase
    {
        private readonly CountryViewModel _countryViewModel;
        public ChangeModeCommand(CountryViewModel countryViewModel)
        {
            _countryViewModel = countryViewModel;
        }
        public override void Execute(object parameter)
        {
            switch ((AddModeEnum)parameter) 
            {
                case AddModeEnum.WannaGo:
                    _countryViewModel.addMode = AddModeEnum.WannaGo;
                    _countryViewModel.SaveCountry = _countryViewModel.SaveWantToTravel;
                    break;
                case AddModeEnum.WasThere:
                    _countryViewModel.addMode = AddModeEnum.WasThere;
                    _countryViewModel.SaveCountry = _countryViewModel.SaveWasThere;
                    break;
            }
            _countryViewModel.dateGridState = true;
                
        }
    }
}
