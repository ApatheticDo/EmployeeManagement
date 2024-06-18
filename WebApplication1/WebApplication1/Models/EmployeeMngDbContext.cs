using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class EmployeeMngDbContext : DbContext
    {
        public EmployeeMngDbContext(DbContextOptions<EmployeeMngDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Section)
            .WithMany(d => d.Employee)
            .HasForeignKey(e => e.Sec_id);

            modelBuilder.Entity<Section>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Section)
            .HasForeignKey(e => e.Depa_id);

            modelBuilder.Entity<Department>()
            .HasOne(e => e.Division)
            .WithMany(d => d.Department)
            .HasForeignKey(e => e.Divi_Id);

            modelBuilder.Entity<Admin>()
            .HasOne(e => e.Division)
            .WithMany(d => d.Admin)
            .HasForeignKey(e => e.Divi_Id);

            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Education)
            .WithMany(d => d.Employee)
            .HasForeignKey(e => e.Edu_Id);

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Division> Divisions { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Education> Educations { get; set; }

    }
}
