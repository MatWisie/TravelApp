﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Commands;
using TravelApp.Interfaces;
using TravelApp.Models;

namespace TravelApp.ViewModels
{
    public class WannaGoViewModel : ViewModelBase, IListOfModels
    {
        private readonly CountryControlModel _countryControlModel;

        public WannaGoViewModel(CountryControlModel countryControlModel)
        {
            _countryControlModel = countryControlModel;
            LoadWantToTravel = new LoadWantToTravelCommand(_countryControlModel, this, "WannaGo.json");
            DeleteSelectedWannaGo = new DeleteSelectedWannaGoCommand(_countryControlModel, this, "WannaGo.json");
        }

        private ObservableCollection<CountryControlModel> _listOfModels = new ObservableCollection<CountryControlModel>();

        public ObservableCollection<CountryControlModel> ListOfModels
        {
            get { return _listOfModels; }
            set 
            {
                _listOfModels = value;
                OnPropertyChanged(nameof(ListOfModels));
            }
        }

        public ICommand LoadWantToTravel { get; }
        public ICommand DeleteSelectedWannaGo { get; }
    }
}
