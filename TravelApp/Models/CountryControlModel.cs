using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace TravelApp.Models
{
    public class CountryControlModel
    {
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        private string _NativeName;
        public string NativeName 
        {
            get
            {
                return _NativeName;
            }
            set
            {
                _NativeName = value;
            }
        }
        private string _Capital;
        public string Capital 
        {
            get
            {
                return _Capital;
            }
            set
            {
                _Capital = value;
            }
        }
        private string _Region;
        public string Region 
        {
            get
            {
                return _Region;
            }
            set
            {
                _Region = value;
            }
        }
        private int _Population;
        public int Population 
        {
            get
            {
                return _Population;
            }
            set
            {
                _Population = value;
            } 
        }
        private double _Area;
        public double Area 
        {
            get
            {
                return _Area;
            }
            set
            {
                _Area = value;
            }
        }
        private string _NumericCode;
        public string NumericCode 
        {
            get
            {
                return _NumericCode;
            }
            set
            {
                _NumericCode = value;
            }
        }
        private string _Flags;
        public string Flags 
        {
            get
            {
                return _Flags;
            }
            set
            {
                _Flags = value;
            }
        }

        private List<CurrencyModel> _Currencies;
        public List<CurrencyModel> Currencies 
        {
            get
            {
                return _Currencies;
            }
            set
            {
                _Currencies = value;
            }
        }

        private List<LanguageModel> _Languages;

        public List<LanguageModel> Languages
        {
            get { return _Languages; }
            set { _Languages = value; }
        }

        private int? _Index;
        public int? Index 
        {
            get
            {
                return _Index;
            }
            set
            {
                _Index = value;
            }
        }
        private DateTime? _FromDate;
        public DateTime? FromDate 
        {
            get
            {
                return _FromDate;
            }
            set
            {
                _FromDate = value;
            }
        }
        private DateTime? _ToDate;
        public DateTime? ToDate 
        {
            get
            {
                return _ToDate;
            }
            set
            {
                _ToDate = value;
            }
        }
        private string _Note;
        public string Note
        {
            get
            {
                return _Note;
            }
            set
            {
                _Note = value;
            }
        }


        public static CountryControlModel operator +(CountryControlModel countryControlModel, int integer)
        {
            countryControlModel.Index = integer;
            return countryControlModel;
        }
        public async Task<CountryModel> LoadCountry()
        {
            var client = new RestClient();
            var request = new RestRequest("https://restcountries.com/v2/name/" + Name + "?fields=name,nativeName,capital,region,population,area,numericCode,flags,currencies,languages");
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
