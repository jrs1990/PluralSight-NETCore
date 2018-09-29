using OdeToFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewModels
{
    public class HomeIndexViewModels
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public String CurrentMessage { get; set; }
    }
}
