using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace PincodeREST.Model
{
    public partial class PincodeDbContext : DbContext
    {
        public PincodeDbContext()
            : base("PincodeDBConnection")
        {

        }   

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<PincodeDetail> PincodeDetails { get; set; }
    }
}
