namespace TravelApp.Models
{
    public class FlagsModel
    {
        private string _svg;
        public string svg 
        {
            get
            {
                return _svg;
            }
            set
            {
                _svg = value;
            }
        }
        private string _png;
        public string png 
        {
            get
            {
                return _png;
            }
            set
            {
                _png = value;
            }
        }
    }
}
