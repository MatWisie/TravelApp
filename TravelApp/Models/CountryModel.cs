using System.Collections.Generic;

namespace TravelApp.Models
{
    public class CountryModel
    {
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }
        public string NumericCode { get; set; }
        public FlagsModel Flags { get; set; } 
        public List<CurrencyModel> Currencies { get; set; }
        public List<LanguageModel> Languages { get; set; }

    }
}
