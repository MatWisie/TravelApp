using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.Models
{
    public class CountryControlModel
    {
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }
        public string NumericCode { get; set; }
        public string Flag { get; set; }

        public async Task<CountryModel> LoadCountry()
        {
            var client = new RestClient();
            var request = new RestRequest("https://restcountries.com/v2/name/" + Name + "?fields=name,nativeName,capital,region,population,area,numericCode,flag");
            var response = await client.GetAsync<List<CountryModel>>(request);

            return response[0];
        }
    }
}
