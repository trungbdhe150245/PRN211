using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.Models
{
    internal class Test
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime TestDate { get; set; }
        public TimeSpan Duration { get; set; }
        public Subject Subject { get; set; }
        public bool IsReview { get; set; }
    }
}
