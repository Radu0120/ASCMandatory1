﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCMandatory1
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static Position Create(int x, int y)
        {
            return new Position() { X = x, Y = y };
        }
    }
}