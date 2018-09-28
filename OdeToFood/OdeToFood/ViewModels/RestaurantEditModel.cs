using OdeToFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public String Name { get; set; }
        public CusineType Cusine { get; set; }
    }
}
