using System;
using System.Collections.Generic;
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
        public List<CountryNameModel> Countries { get; }
        public ViewModelBase CurrentView { get; set; }

        public MainWindowModel()
        {
            Date = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
