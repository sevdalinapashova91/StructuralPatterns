﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternExample
{
    public class DigitFour : Digit
    {
        public DigitFour()
        {
            this.Symbol = '4';
            this.Height = 100;
            this.Width = 120;
            this.Ascent = 70;
            this.Descent = 0;
        }

        public override void Display(int pointSize)
        {
            Console.WriteLine("{0} (point size {1})", this.Symbol, pointSize);
        }
    }
}
