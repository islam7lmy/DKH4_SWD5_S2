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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Id)
                .UseIdentityColumn(10, 10);

            builder.Property(d => d.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(d => d.CreationDate)
                .HasComputedColumnSql("CONVERT(date, GETDATE())");
        }
    }
}
