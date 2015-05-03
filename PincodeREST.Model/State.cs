using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PincodeREST.Model
{
    public partial class State
    {
        public int StateId { get; set; }
        public string Name { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<District> Districts { get; set; }
    }
}
