using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceDeskAppProject.Models;

namespace ServiceDeskAppProject.Models
{
    public class ServiceDeskDbContext:IdentityDbContext<AppUser>
    {
        public ServiceDeskDbContext(DbContextOptions<ServiceDeskDbContext> dbContextOptions):base(dbContextOptions)
        {

        }
        public virtual DbSet<ClientCard> ClientCards { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<SelledLicense> SelledLicenses { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Incident>()
                      .HasOne(x => x.AppUser)
                           .WithMany(y => y.Incidents)
                                .HasForeignKey(x => x.AppUserId);
            base.OnModelCreating(builder);
        }

        public DbSet<ServiceDeskAppProject.Models.RegisterModel> RegisterModel { get; set; }
    }
}
