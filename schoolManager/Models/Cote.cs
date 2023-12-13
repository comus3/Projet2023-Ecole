namespace schoolManager.Models;

public class Cote : Eval
{
    private int note;
    public Cote(int note,Activite activite,List<Eval> listEval): base(activite,listEval)
    {
        this.note = note;

    }
    public override int Note()
    {
        return note;
    }
    public void SetNote(int note)
    {
        this.note = note;
    }

}
