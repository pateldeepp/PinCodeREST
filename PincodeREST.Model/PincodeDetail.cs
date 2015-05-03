using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PincodeREST.Model
{
    public partial class PincodeDetail
    {
        public int PincodeDetailId { get; set; }
        public string Pincode { get; set; }
        public string OfficeType { get; set; }
        public string DeliveryStatus { get; set; }
        public string Division { get; set; }
        public string Region { get; set; }
        public string Circle { get; set; }
        public string Taluka { get; set; }
        public string Telephone { get; set; }
        public string RelatedSubOffice { get; set; }
        public string RelatedHeadOffice { get; set; }

        public virtual District District { get; set; }
    }
}
