using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using dreviny.Models;

namespace dreviny.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<dreviny.Models.Drevina> Drevina { get; set; }
        public DbSet<dreviny.Models.Odruda> Odruda { get; set; }
    }
}
