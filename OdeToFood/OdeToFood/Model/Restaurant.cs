using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Model
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Display(Name="Restaurant Name: ")]
        [Required, MaxLength(80)]
        public String Name { get; set; }

        public CusineType Cusine { get; set; }
    }
}
