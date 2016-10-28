namespace FacadePatternExample
{
    using Contracts;

    public class Terminal : IElectrical
    {
        public void ConsumeElectricity(IWriter writer)
        {
            writer.WriteLine("I don't consume anything");
        }

        public void DoWork(IWriter writer)
        {
            writer.WriteLine("I connect wires");
        }
    }
}
