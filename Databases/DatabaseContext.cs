using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using csharp_asp_dotnet_mvc.Models;

namespace csharp_asp_dotnet_mvc.Databases
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=aspdotnet;user=root;password=kieuminhvu;Charset=utf8;");
        }
    }
}