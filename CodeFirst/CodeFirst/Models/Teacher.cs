using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
