using Microsoft.EntityFrameworkCore;
using sampleAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleAPI.Models.Context
{
    public class DataBaseContext:DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)

        {

        }

        public DbSet<Product> Products { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SampleDB;Integrated Security=True;");
        //}
    }
}
