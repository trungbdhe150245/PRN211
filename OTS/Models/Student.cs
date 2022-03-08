using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.Models
{
    internal class Student
    {
        public int Id { get; set; } 
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StudentCode { get; set; }
        public Class Class { get; set; }
    }
}
