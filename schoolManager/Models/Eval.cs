namespace schoolManager.Models;

public abstract class Eval
{
    public Activite activite;
    private static List<Eval> listEval = new List<Eval>{};

    public Eval(Activite activite)
    {
        this.activite = activite;
        listEval.Add(this);
    }
    public abstract int Note();
    public static List<Eval> getListEval()
    {
        return listEval;
    }

}
