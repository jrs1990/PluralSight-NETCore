using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;

        public string CurrentGreeting { get; set; }
        public GreetingModel(IGreeter greeter)
        {
            this._greeter = greeter;
        }
        public void OnGet(String name)
        {
            this.CurrentGreeting =  $"{name}: {this._greeter.GetMessageOfDay()}" ;

        }
    }
}