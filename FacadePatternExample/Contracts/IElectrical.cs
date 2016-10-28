using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample.Contracts
{
    public interface IElectrical
    {
        void ConsumeElectricity(IWriter writer);
        void DoWork(IWriter writer);

    }
}
