﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Interfaces;
using TravelApp.Models;
using TravelApp.ViewModels;

namespace TravelApp.Commands
{
    public class DeleteSelectedWannaGoCommand : CommandBase
    {
        private readonly IListOfModels _viewModel;
        private readonly CountryControlModel _countryControlModel;
        private string _fileName;
        public DeleteSelectedWannaGoCommand(CountryControlModel countryControlModel,IListOfModels viewModel, string fileName)
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
