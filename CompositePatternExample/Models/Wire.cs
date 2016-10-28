using CompositePatternExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternExample.Models
{
    public class Wire : IElectrical
    {
        public int DoWork()
        {
            Console.WriteLine("I direct electricity to consumer");
            return -1;
        }
    }
}
