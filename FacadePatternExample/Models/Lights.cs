namespace FacadePatternExample
{
    using Contracts;

    public class Lights : IElectrical
    {
        public void ConsumeElectricity(IWriter writer)
        {
            writer.WriteLine("I consume little electricity but without me it is dark");
        }

        public void DoWork(IWriter writer)
        {
            writer.WriteLine("I shine");
        }
    }
}
