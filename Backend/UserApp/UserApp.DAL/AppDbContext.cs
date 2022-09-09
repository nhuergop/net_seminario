using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using UserApp.DAL.Entities;


namespace UserApp.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server:localhost:3000;database:userapp;user=root;password=");
        }
        public DbSet<Entities.User> Users { get; set; }

        public DbSet<Entities.Group> Groups { get; set; }
    }
}
