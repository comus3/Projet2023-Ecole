namespace schoolManager.Models;

public class Cote : Eval
{
    private int note;
    public static List<Cote> listCote;
    public Cote(int note,Activite activite): base(activite)
    {
        this.note = note;
        listCote.Add(this);

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
