using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        
        public String Phone()
        {
            return "11 984023261";
        }

        
        public String Address()
        {
            return "Rua Paim, 90";

        }
    }
}
