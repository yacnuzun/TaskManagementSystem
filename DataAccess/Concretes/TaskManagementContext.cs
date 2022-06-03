using DataAccess.Concretes.Mappings;
using Enities.Concretes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class TaskManagementContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=...; Database=TaskManagement; Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<UserRole>(new UserRoleMapping());
        }
        public virtual DbSet<Duty> Duties { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Statu> Status { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UsersRoles { get; set; }

    }
}
