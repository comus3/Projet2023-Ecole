namespace schoolManager.Models;

public abstract class Eval
{
    public Activite activite;
    public List<Eval> listEval;

    public Eval(Activite activite,List<Eval> listEval)
    {
        this.activite = activite;
        this.listEval = listEval;
        this.listEval.Add(this);
    }
    public abstract int Note();
    

}
