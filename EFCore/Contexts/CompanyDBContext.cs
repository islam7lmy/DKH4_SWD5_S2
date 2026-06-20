using EFCore.Configurations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class CompanyDBContext : DbContext
    {
        //"Data Source = ISLAM7LMY\\ISLAM7LMY; intial Catalog = S2E.EFMYCompany; Integrated Security = True"
        //"Data Source = ISLAM7LMY\\ISLAM7LMY; intial Catalog = S2E.EFMYCompany; User Id = sa; Password = Islam@123"
        //"Server = ISLAM7LMY\\ISLAM7LMY; Database = S2E.EFMYCompany; Trusted_Connection = True"

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ISLAM7LMYLAPVM\\ISLAM7LMY;Initial Catalog=DKH4_SWD5_S2.EFMYCompany;Integrated Security=True;Encrypt=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // when inhert from dbcontext contain dbsets as scurity modual has 7 dbsets
            // inhert IdentityDbContext
            //base.OnModelCreating(modelBuilder);

            #region 3. Fluent API
            #region ways to Access Property
            //modelBuilder.Entity<Employee>()
            //    .Property("Name")
            //    .HasDefaultValue("No Name");


            //modelBuilder.Entity<Employee>()
            //   .Property(nameof(Employee.Name))
            //   .HasDefaultValue("No Name");

            //modelBuilder.Entity<Employee>()
            //    .Property(e=>e.Name)
            //    .HasDefaultValue("No Name");
            #endregion

            #region Shadow Property
            //modelBuilder.Entity<Employee>()
            //    .Property<string>("Address")
            //    .HasColumnType("nvarchar(100)");
            #endregion

            #region Mapping To Class
            //modelBuilder.Entity<Department>()
            //    .ToTable("DepartmentsInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //modelBuilder.Entity<Department>()
            //    .Property(d=>d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(100)
            //    .IsRequired();

            //modelBuilder.Entity<Department>()
            //    .Property<DateOnly>(d => d.CreationDate)
            //    .HasColumnType("date")
            //    .HasComputedColumnSql("GETDATE()");

            ///efcore 3.1 new feature
            //modelBuilder.Entity<Department>(d =>
            //{
            //    d.ToTable("DepartmentsInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //    d.Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //    d.Property(d => d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(100)
            //    .IsRequired();

            //    d.Property<DateOnly>(d => d.CreationDate)
            //    .HasColumnType("date")
            //    .HasComputedColumnSql("GETDATE()");
            //});
            #endregion

            #endregion

            #region 4. ConfigurationClass Per Entity
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
