﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HN_Wrapper
{
    public class PollPart : Item
    {
        public int Parent { get; set; }
        public int Score { get; set; }
        public string Text { get; set; }
    }
}