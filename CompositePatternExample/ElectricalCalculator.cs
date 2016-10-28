using CompositePatternExample.Contracts;
using System.Collections.Generic;

namespace CompositePatternExample
{
    public class ElectricalCalculator
    {
        public int CalculatePowerLosses(IEnumerable<IElectrical> electricalObjects)
        {
            int calculateLosses = 0;
            foreach (var electricalObject in electricalObjects)
            {
                calculateLosses += electricalObject.DoWork();
            }
            return calculateLosses;
        }
    }
}
