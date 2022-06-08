using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }

    public enum Gender
    {
        Female,Male,Other
    }
}
