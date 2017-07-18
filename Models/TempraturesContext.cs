using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace raspberry_api.Models
{
    public class TempraturesContext : DbContext
    {
        public TempraturesContext(DbContextOptions options) : base(options)
        {}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Reading>().HasKey(x => x.Id);
            builder.Entity<Reading>()
            .Property(b => b.TimeStamp)
            .HasDefaultValue(DateTime.Now);
            base.OnModelCreating(builder);
        }
        public DbSet<Reading> Readings { get; set; }
    }

    public class Reading
    {
        public int Id { get; set; }
        public float Temprature { get; set; }
        public float Humidity { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}