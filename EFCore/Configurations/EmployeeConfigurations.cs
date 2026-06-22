using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property<string>("Address")
                .HasColumnType("nvarchar(100)");

            //builder.HasOne(e=>e.Department)
            //    .WithMany(d=>d.Employees)
            //    .HasForeignKey(e=>e.DepartmentDeptId)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Department>()
                .WithMany()
                .HasForeignKey(e => e.DepartmentDeptId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(e => e.DepartmentToManage)
            //    .WithOne(d=>d.Manager)
            //    .HasForeignKey<Department>(d=>d.ManagerId)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasAlternateKey(e => e.EmployeeCode);
            builder.HasMany<Attendance>()
                .WithOne()
                .HasForeignKey(a => a.EmployeeCode)
                .HasPrincipalKey(e => e.EmployeeCode);
        }
    }

    class EmployeeRelationConfigurations : IEntityTypeConfiguration<EmployeeRelation>
    {
        public void Configure(EntityTypeBuilder<EmployeeRelation> builder)
        {
            builder.HasKey(e => new
            {
                e.EmployeeId,
                e.ColleagueId
            }); //composite primary key

            builder.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(e => e.ColleagueId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
