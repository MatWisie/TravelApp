using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.Models
{
    public class LanguageModel
    {
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _nativeName;

        public string nativeName
        {
            get { return _nativeName; }
            set { _nativeName = value; }
        }

    }
}
