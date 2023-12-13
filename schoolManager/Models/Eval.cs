namespace schoolManager.Models;

public abstract class Eval
{
    public Activite activite;
    public List<Eval> listEval;

    public Eval(Activite activite)
    {
        this.activite = activite;
        listEval.Add(this);
    }
    public abstract int Note();
    

}
