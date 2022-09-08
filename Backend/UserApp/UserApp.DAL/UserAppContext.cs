using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserApp.DAL
{
    public class UserAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server:localhost:3000;database:userapp;user=root;password=");
        }
        public DbSet<UserApp.DAL.Entities.UserContext> Users { get; set; }

        public DbSet<UserApp.DAL.Entities.GroupContext> Groups { get; set; }
    }
}
