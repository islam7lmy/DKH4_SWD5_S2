using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Employee
    {
        public int Id { get; set; } //int pk identity(1,1) not allow null
        public string? Name { get; set; } //nvarchar(max) allow null
        public double Salary { get; set; } //float not allow null
        public int? Age { get; set; } //int allow null
    }
}
