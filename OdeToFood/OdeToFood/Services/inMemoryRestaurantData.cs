using OdeToFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class inMemoryRestaurantData: IRestaurantData
    {
        private List<Restaurant> _restaurants;
        public inMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1, Name="Scott's Pizza Place"},
                new Restaurant{Id=1, Name="Tersiguels"},
                new Restaurant{Id=1, Name="Kings Contrivance"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(a => a.Name);
        }
    }
}
