using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.Models
{
    internal class Submission
    {
        public Test Test { get; set; }
        public Student Student { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }
    }
}
