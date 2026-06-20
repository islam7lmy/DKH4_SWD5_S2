using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    #region Properties Mapping
    /// Ef Core Suppotes 4 ways for mapping
    /// 1. by Convention (Default)
    /// 2. Data Annotations [set of attributes used for valdation]
    /// 3. Fluent API (set of methods to do congfigurations)
    /// 4. ConfigurationClass Per Entity => Organized 3rd way 

    #region 1. by Convention (Default Bhavior)
    //internal class Employee
    //{
    //    public int Id { get; set; } //int pk identity(1,1) not allow null
    //    public string? Name { get; set; } //nvarchar(max) allow null
    //    public double Salary { get; set; } //float not allow null
    //    public int? Age { get; set; } //int allow null
    //}
    #endregion

    #region 2. Data Annotations
    //[Table("EmployeesInfo", Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; } //int pk identity(1,1) not allow null

    //    [Required]
    //    [Column(TypeName = DBTypes.Varchar)] // [Column(TypeName = "varchar")]
    //    [MaxLength(100)]
    //    [StringLength(50, MinimumLength = 5)]
    //    public string? Name { get; set; } //nvarchar(max) allow null

    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; } //float not allow null

    //    [Range(22, 60)]
    //    public int? Age { get; set; } //int allow null

    //    [DataType(DataType.EmailAddress)]
    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [NotMapped]
    //    public int Test { get; set; }

    //    public double NetSalary { get { return Salary * .9; } }
    //}
    #endregion

    #region 3. Fluent API
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
    }
    #endregion

    #endregion

    public static class DBTypes
    {
        public const string Varchar = "varchar";
        public const string NVarchar = "nvarchar";
        public const string Int = "int";
        public const string Float = "float";
    }
}
