using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ApplicationDbContext : DbContext       //třída přidána na začátku
    {
        public DbSet<Assignee> AssigneeDatabase { get; set; }           //samostatné tabulky
        public DbSet<ToDo> ToDoDatabase { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)     //přidáno na začátku (constructor)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)          //definuje vztah mezi tabulkami
        {
            modelBuilder.Entity<Assignee>()
                .HasMany<ToDo>(a => a.AssigneeToDos)
                .WithOne(u => u.Assignee)
                .HasForeignKey(a => a.AssigneeId)
                .IsRequired(false);
        }
    }
}
