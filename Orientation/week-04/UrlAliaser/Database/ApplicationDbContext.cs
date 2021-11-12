using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlAliaser.Models;

namespace UrlAliaser.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Form> FormDatabase { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
