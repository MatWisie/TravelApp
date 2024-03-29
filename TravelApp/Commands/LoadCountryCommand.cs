﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Interfaces;
using TravelApp.Models;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class LoadCountryCommand : CommandBase
    {
        private readonly CountryControlModel _countryControlModel;
        private readonly IListOfModels _viewModel;
        private string _fileName;
        public LoadCountryCommand(CountryControlModel countryControlModel, IListOfModels viewModel, string fileName)
        {
            _countryControlModel = countryControlModel;
            _viewModel = viewModel;
            _fileName = fileName;
        }
        public override void Execute(object parameter)
        {
            List<CountryControlModel> tmpList = _countryControlModel.Load(_fileName);

            if(tmpList != null)
            for(int i = 0; i < tmpList.Count; i++) 
            {
                _viewModel.ListOfModels.Add(tmpList[i]);
                    _viewModel.ListOfModels[i] += i+1;
            }
        }
    }
}
