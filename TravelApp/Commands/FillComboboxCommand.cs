using TravelApp.Models;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    internal class FillComboboxCommand : CommandBase
    {
        private readonly MainWindowModel _mainWindowModel;
        private readonly MainWindowViewModel _mainWindowViewModel;
        public FillComboboxCommand(MainWindowViewModel mainWindowViewModel, MainWindowModel mainWindowModel)
        {
            _mainWindowModel = mainWindowModel;
            _mainWindowViewModel = mainWindowViewModel;
        }
        public override async void Execute(object parameter)
        {
           _mainWindowViewModel.countries = await _mainWindowModel.LoadCountries();
        }
    }
}
