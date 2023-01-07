using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        public string Flags { get; set; }
        public List<CurrencyModel> Currencies { get; set; }
        public int? Index { get; set; }

        public async Task<CountryModel> LoadCountry()
        {
            var client = new RestClient();
            var request = new RestRequest("https://restcountries.com/v2/name/" + Name + "?fields=name,nativeName,capital,region,population,area,numericCode,flags,currencies");
            var response = await client.GetAsync<List<CountryModel>>(request);

            return response[0];
        }

        public void Save(string filename) 
        {
            if (File.Exists(filename)) 
            {
                List<CountryControlModel> _data = Load(filename);
                _data.Add(this);
                string json = JsonSerializer.Serialize(_data);
                File.WriteAllText(filename, json);
            }
            else
            {
                List<CountryControlModel> _data = new List<CountryControlModel>();
                _data.Add(this);
                string json = JsonSerializer.Serialize(_data);
                File.WriteAllText(filename, json);
            }

        }
        public void Save(string filename, List<CountryControlModel> _data) 
        {
            if (File.Exists(filename)) 
            {
                string json = JsonSerializer.Serialize(_data);
                File.WriteAllText(filename, json);
            }
        }

        public List<CountryControlModel> Load(string filename)
        {
            if (File.Exists(filename)) 
            { 
            string jsonString = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<List<CountryControlModel>>(jsonString);
            }
            else 
            {
                return null;
            }
        }
    }
}
