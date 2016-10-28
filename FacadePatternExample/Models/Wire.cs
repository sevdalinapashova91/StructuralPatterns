using FacadePatternExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample
{
    public class Wire : IElectrical
    {
        public void ConsumeElectricity(IWriter writer)
        {
            writer.WriteLine("I don't consume electricity");
        }

        public void DoWork(IWriter writer)
        {
            writer.WriteLine("I connect symbols and potentials");
        }
    }
}
