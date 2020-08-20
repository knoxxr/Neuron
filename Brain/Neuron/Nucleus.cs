//Nucleus(세포핵) Class

public class Nucleus
{
    public Nuclues()
    {
        
    }

    protected int Activation(ref int x, ref int w, ref int b)
    {
        return x*w+b;
    }

    protected int Sigmoid(ref int x)
    {
        if(x<-45) return 0;
        else if(x>45) return 1;
        else return 1/(1+Math.Exp(-x));
    }
}