using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public DbSet<Employee> Employees { get; set; }
    }
}
