namespace seance2;

public abstract class Eval
{
    public Activite activite;
    public Eval(Activite activite)
    {
        this.activite = activite;
    }
    public abstract int Note();
    

}
