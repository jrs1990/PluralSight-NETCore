﻿using OdeToFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    //public class InMemoryRestaurantData: IRestaurantData
    //{
    //    private List<Restaurant> _restaurants;
    //    public InMemoryRestaurantData()
    //    {
    //        _restaurants = new List<Restaurant>
    //        {
    //            new Restaurant{Id=1, Name="Scott's Pizza Place"},
    //            new Restaurant{Id=2, Name="Tersiguels"},
    //            new Restaurant{Id=3, Name="Kings Contrivance"},
    //            new Restaurant{Id=4, Name="La Boca"}
    //        };
    //    }

    //    public Restaurant Add(Restaurant newRestaurante)
    //    {
    //        newRestaurante.Id = _restaurants.Max(r => r.Id) + 1;
    //        _restaurants.Add(newRestaurante);
    //        return newRestaurante;
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(a => a.Id == id);
    //    }

    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return _restaurants.OrderBy(a => a.Name);
    //    }
    //}
}
