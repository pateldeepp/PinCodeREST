using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PincodeREST.Model
{
    public partial class District
    {
        public int DistrictId {get;set;}
        public string Name { get; set; }
        public virtual State State { get; set; }
        public virtual List<PincodeDetail> PincodeDetails { get; set; }
    }
}
