using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace EFCoreNavigationalProperties.Entites
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        //public project Project { get; set; } 
        //public product Product { get; set; }
    }

    //class project
    //{
    //    public  int Id { get; set; }
    //    public string Name { get; set; }
    //}

    //class product
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
