using PincodeREST.Common.Contracts;
using PincodeREST.Model;
using PincodeREST.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PinCodeREST.Controllers
{
    public class CountryController : ApiController
    {
        ILogService loggerService;
        ICountryService _countryService;

        public CountryController(ILogService loggerService, ICountryService countryService)
        {
            this.loggerService = loggerService;
            this._countryService = countryService;
        }
        
        public List<Country> GetAllCountries()
        {
            loggerService.Logger().Info("Get All Countries");
            var countries = _countryService.GetCountries().ToList();
            List<Country> retunValue = new List<Country>();
            foreach (var country in countries)
            {
                var c = new { country.CountryId,  };
                retunValue.Add(country);
            }
            return retunValue;
        }
    }
}
