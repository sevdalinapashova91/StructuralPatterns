using FacadePatternExample.Contracts;
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
