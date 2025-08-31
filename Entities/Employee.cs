using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{
    //EF Core Support 4 Ways For Mapping Classes in Database [Table , view , Function]
    //1. By Convention [default Behaviour]
    //2. Data Annotation [Set of Attributes Used for Data Validation]
    //3.flunet APIs
    //4. class configuration

    //Enity
    //POCO:
    //Plain OlD CLR Object 


    //internal class Employee //Table
    //{
    //    public int Id { get; set; } // public Numeric Property Named 'Id' | EmployeeId --> PK - Identity(1,1)
    //    public string Name { get; set; } // Reference Type : Requried [Not Allow Null] - nvarchar(max)
    //    public int Age { get; set; } // Value Type : int[Age] - Required
    //    public double Salary { get; set; } // Value Type : float [Salary] - required 
    //    public string Email { get; set; } // nvarchar(max) - optional
    //    public DateTime DateofCreation { get; set; } // datatime2 - required
    //}



    //2. Data Annotation 

    //[Table("hamada", Schema = "dbo")]
    //class Employee
    //{
    //    [Key]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpNAme", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Range(0, 50)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string Phone { get; set; }

    //    [Column(TypeName = "money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //}
    //

    class Employee
    {
        public string EmpId { get; set; }

        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public DateTime DateOfCreation { get; set; }
    }
}
