using AuthenticationAndAuthourizationApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAndAuthourizationApp.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OBE3VQV;Database=AuthenticationAppDatabase;Trusted_Connection=True;");
        }
        public DbSet<Student> Students { get; set; }
    }
}
