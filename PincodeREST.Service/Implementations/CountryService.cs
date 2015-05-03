using PincodeREST.DAL.Contracts;
using PincodeREST.Model;
using PincodeREST.Repository;
using PincodeREST.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PincodeREST.Service.Implementations
{
    public class CountryService : ICountryService
    {
        IUnitOfWork unitOfWork;
        ICountryRepository _countryRepository;

        public CountryService(
            IUnitOfWork unitOfWork,
            ICountryRepository countryRepository
            )
        {
            this.unitOfWork = unitOfWork;
            this._countryRepository = countryRepository;
        }

        public List<Country> GetCountries()
        {
            List<Country> countries;
            countries = _countryRepository.GetAll().ToList();
            return countries;
        }

    }
}
