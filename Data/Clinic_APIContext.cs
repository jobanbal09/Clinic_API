using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clinic_API.Model;

namespace Clinic_API.Data
{
    public class Clinic_APIContext : DbContext
    {
        public Clinic_APIContext (DbContextOptions<Clinic_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Clinic_API.Model.Customer> Customer { get; set; }
    }
}
