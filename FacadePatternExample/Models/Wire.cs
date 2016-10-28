namespace FacadePatternExample
{
    using Contracts;
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
