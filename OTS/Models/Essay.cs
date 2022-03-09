﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS.Models
{
    internal class Essay
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Question Question { get; set; }
        public string Content { get; set; }
    }
}