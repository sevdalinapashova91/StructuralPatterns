using FacadePatternExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample
{
    public class Contactor : IElectrical
    {
        public void ConsumeElectricity(IWriter writer)
        {
            writer.WriteLine("I Consume a little electricity but i'm very important");
        }

        public void DoWork(IWriter writer)
        {
            writer.WriteLine("I switch the electricity");
        }
    }
}
