using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.ViewModels;
using TravelApp.Views;

namespace TravelApp.Models
{
    public class MainWindowModel
    {
        public string Date { get; }
        public ObservableCollection<CountryNameModel> Countries { get; set; }
        public ViewModelBase CurrentView { get; set; }

        public MainWindowModel()
        {
            Date = DateTime.Now.ToString("dd.MM.yyyy");
        }

        public async Task<ObservableCollection<CountryNameModel>> LoadCountries()
        {
            var client = new RestClient();
            var request = new RestRequest("https://restcountries.com/v2/all?fields=name");
            var response = await client.GetAsync<ObservableCollection<CountryNameModel>>(request);


            return response;
        }
    }
}
