using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class Greeter : IGreeter
    {
        private IConfiguration _config;
        public Greeter(IConfiguration config)
        {
            this._config = config;
        }
        public string GetMessageOfDay()
        {
            var retorno = _config["Greeting"];

            return retorno;
        }
    }
}
