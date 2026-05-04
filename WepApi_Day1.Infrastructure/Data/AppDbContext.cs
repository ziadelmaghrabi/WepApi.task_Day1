using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WepApi_Day1.Core.Entities;

namespace WepApi_Day1.Infrastructure.Data
{
     public  class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {}

        public DbSet<Course>Courses { get; set; }

        //configration of the model -->fluent Api 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }





    }
}
