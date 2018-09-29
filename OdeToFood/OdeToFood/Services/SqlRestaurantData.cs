using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Data;
using OdeToFood.Model;

namespace OdeToFood.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private OdeToFoodDBContext _context;
        public SqlRestaurantData(OdeToFoodDBContext context)
        {
            _context = context;
        }
        public Restaurant Add(Restaurant newRestaurante)
        {
            _context.Restaurants.Add(newRestaurante);
            _context.SaveChanges();
            return newRestaurante;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
           return _context.Restaurants.OrderBy(r => r.Name);
        }
    }
}
