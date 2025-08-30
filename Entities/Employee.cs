using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{
    //EF Core Support 4 Ways For Mapping Classes in Database [Table , view , Function]
    //1. By Convention [default Behaviour]
    

    //Enity
    //POCO:
    //Plain OlD CLR Object 
    internal class Employee //Table
    {
        public int Id { get; set; } // public Numeric Property Named 'Id' | EmployeeId --> PK - Identity(1,1)
        public string Name { get; set; } // Reference Type : Requried [Not Allow Null] - nvarchar(max)
        public int Age { get; set; } // Value Type : int[Age] - Required
        public double Salary { get; set; } // Value Type : float [Salary] - required 
        public string Email { get; set; } // nvarchar(max) - optional
        public DateTime DateofCreation { get; set; } // datatime2 - required

    }
}
