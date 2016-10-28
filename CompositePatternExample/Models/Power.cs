using CompositePatternExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternExample.Models
{
    public class Power : IElectrical
    {
        public int DoWork()
        {
            Console.WriteLine("I give power to the electrical circuit");
            return 10;
        }
    }
}
