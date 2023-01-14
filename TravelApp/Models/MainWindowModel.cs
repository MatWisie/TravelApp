using RestSharp;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TravelApp.ViewModels;

namespace TravelApp.Models
{
    public class MainWindowModel
    {
        private readonly string _Date;
        public string Date 
        {
            get 
            { 
                return _Date; 
            } 
        }
        private ObservableCollection<CountryNameModel> _Countries;
        public ObservableCollection<CountryNameModel> Countries 
        {
            get
            {
                return _Countries;
            }
            set
            {
                _Countries = value;
            }
        }

        public MainWindowModel()
        {
            _Date = DateTime.Now.ToString("dd.MM.yyyy");
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
