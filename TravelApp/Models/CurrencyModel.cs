namespace TravelApp.Models
{
    public class CurrencyModel
    {
        private string _code;
        public string code 
        {
            get 
            { 
                return _code; 
            }
            set
            {
                _code = value;
            }
        }
        private string _name;
        public string name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private string _symbol;
        public string symbol 
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
            }
        }
    }
}
