using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class Student
    {
        public  string InternalStudentId { get; set; }
        public  string Name { get; set; }
        public int M1 { get; set; }
        public DateTime  Dob { get; set; }
        public string  Dob2 { get; set; }
        public long  EditedTime { get; set; }
        public int TotalMark { get; set; }
        public string Remark  { get; set; }

        public string M22 { get; set; }
    }
}
