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
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => new 
            { 
                sc.StudentId, 
                sc.CourseId 
            }); // Composite primary key

            builder.HasOne<Student>()
                .WithMany()
                .HasForeignKey(sc => sc.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey(sc => sc.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
