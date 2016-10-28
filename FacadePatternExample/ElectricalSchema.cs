namespace FacadePatternExample
{
    using Contracts;
    public class ElectricalSchema
    {
        public void DrawSchema(IWriter writer)
        {
            var bottomPotential = new Potential();
            var topPotential = new Potential();
            var wire = new Wire();
            var light = new Lights();
            var terminal = new Terminal();
            var contactor = new Contactor();
            bottomPotential.DoWork(writer);
            topPotential.DoWork(writer);
            wire.DoWork(writer);
            light.DoWork(writer);
            contactor.DoWork(writer);
            terminal.DoWork(writer);            
        }

    }
}
