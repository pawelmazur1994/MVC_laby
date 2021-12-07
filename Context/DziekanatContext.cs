using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_laby.Models;

namespace MVC_laby.Context
{
    public class DziekanatContext : DbContext
    {
        public DziekanatContext(DbContextOptions<DziekanatContext> options)
             : base(options)
        {

        }
        public DbSet<Zajecia> Zajecia { get; set; }
        public DbSet<Student> Student { get; set; }


    }
}