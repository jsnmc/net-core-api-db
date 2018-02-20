using Microsoft.EntityFrameworkCore;
using System;
using DataObjects;

namespace Infrastructure
{
    public class BuildContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public BuildContext(DbContextOptions<BuildContext> options) : base(options)
        {
        }

        public DbSet<BuildItem> BuildItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //..builder.ApplyConfiguration(new CatalogBrandEntityTypeConfiguration());
        }
    }
}
