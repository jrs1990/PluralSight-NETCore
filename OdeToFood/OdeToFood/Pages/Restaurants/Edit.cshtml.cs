using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Model;
using OdeToFood.Services;

namespace OdeToFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {

        private IRestaurantData _restaurantData;

        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public EditModel(IRestaurantData restaurantData)
        {
            this._restaurantData = restaurantData;
        }
        public IActionResult OnGet(int id)
        {
           this.Restaurant = _restaurantData.Get(id);
            if(this.Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _restaurantData.Update(this.Restaurant);
                return RedirectToAction("Details", "Home", new { id = this.Restaurant.Id });
            }
            return Page();
        }
    }
}