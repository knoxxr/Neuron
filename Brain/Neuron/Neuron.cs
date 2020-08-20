public class Neuron
{
    public enum Layer
    {
        INPUT,
        HIDDEN,
        OUTPUT
    }

    public Neuron()
    {
        public Guid _ID = new Guid();
        public Layer _Layer;
        public int _Input = -1;
        public int _Bais = -1;
        public int _Output = -1;

        protected CellBody _CellBody = new CellBody();
        protected List<Axon> _Outputs = new List<Axon>();
        protected  List<Dendrite> _Inputs = new List<Dendrite>();

        public Neuron()
        {

        }      
    }
}