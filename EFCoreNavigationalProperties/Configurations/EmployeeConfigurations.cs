using EFCoreNavigationalProperties.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreNavigationalProperties.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(e => e.Address)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .HasDefaultValue("Cairo");

            builder.Property(e => e.Salary)
                .HasColumnType("decimal(12,2)");
        }
    }
}
