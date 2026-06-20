using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> d)
        {
            d.ToTable("DepartmentsInfo", "dbo")
                .HasKey(d => d.DeptId);

            d.Property(d => d.DeptId)
            .UseIdentityColumn(10, 10);

            d.Property(d => d.Name)
            .HasColumnName("DepartmentName")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

            d.Property<DateOnly>(d => d.CreationDate)
            .HasColumnType("date")
            .HasComputedColumnSql("GETDATE()");
        }
    }
}
