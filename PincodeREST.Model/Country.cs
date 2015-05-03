using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PincodeREST.Model
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public virtual List<State> States { get; set; }
    }
}
