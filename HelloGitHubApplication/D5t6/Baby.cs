﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5t6
{
    class Baby : Human
    {
        public string Diaper { get; set; }
        public override void Move(int amount)
        {
            Console.WriteLine("Baby is crawling");
        }
    }
}
