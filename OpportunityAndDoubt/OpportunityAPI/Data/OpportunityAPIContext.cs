using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace OpportunityAPI.Data
{
    public class OpportunityAPIContext : DbContext
    {
        public OpportunityAPIContext (DbContextOptions<OpportunityAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Opportunity> Opportunity { get; set; } = default!;
    }
}
