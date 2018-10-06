using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private IGreeter _gretter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _gretter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _gretter.GetMessageOfDay();
            return View("Default", model);
        }
    }
}
