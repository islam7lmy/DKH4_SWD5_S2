using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreNavigationalProperties.Entites
{
    internal class EmployeeDepartment
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
    }
}
