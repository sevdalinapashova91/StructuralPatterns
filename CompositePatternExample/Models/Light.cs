using CompositePatternExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternExample
{
    public class Light : IElectrical
    {
        public int DoWork()
        {
            Console.WriteLine("Shine shine and consume electricity");
            return -5;
        }
    }
}
