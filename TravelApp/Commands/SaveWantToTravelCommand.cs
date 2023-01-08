﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Models;

namespace TravelApp.Commands
{
    public class SaveWantToTravelCommand : CommandBase
    {
        private readonly CountryControlModel _countryControlModel;
        private string _fileName;
        public SaveWantToTravelCommand(CountryControlModel countryControlModel, string fileName)
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
