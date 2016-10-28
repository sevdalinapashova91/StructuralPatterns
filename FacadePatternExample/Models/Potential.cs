﻿using FacadePatternExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample
{
    public class Potential : IElectrical
    {
        public void ConsumeElectricity(IWriter writer)
        {
            writer.WriteLine("I don't consume anything :)");
        }

        public void DoWork(IWriter writer)
        {
            writer.WriteLine("I connect all electrical symbols to electrycity");
        }
    }
}
