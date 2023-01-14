using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TravelApp.Stores;

namespace TravelApp
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        private string _searchedCountry;
        public string searchedCountry 
        {
            get
            {
                return _searchedCountry;
            }
            set
            {
                _searchedCountry = value;
            }
        }
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new NavigationStore();
        }
    }
}
