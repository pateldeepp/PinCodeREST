using PincodeREST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PincodeREST.Service.Contracts
{
    public interface ICountryService
    {
        List<Country> GetCountries();
    }
}
