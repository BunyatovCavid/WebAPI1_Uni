using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAPI1_Uni.Domain.Entities;

namespace WebAPI1_Uni.Domain
{
    public class WorldDbContext:DbContext
    {

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }


        //base-de (Program.cs-de) qeyd olunan options-lara istifade ede bilmek ucun yazilib
        public WorldDbContext(DbContextOptions<WorldDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Fluent Api

            //one to many

            builder.Entity<City>()
                .HasOne(c => c.Country)
                .WithMany(coun => coun.City)
                .HasForeignKey(c=>c.CountryId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
