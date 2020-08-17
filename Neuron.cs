public class Neuron
{
    public Neuron()
    {
        protected CellBody _CellBody = new CellBody();
        protected List<Axon> _Axon = new List<Axon>();
        protected  List<Dendrite> Dendrites = new List<Dendrite>();
    }
}