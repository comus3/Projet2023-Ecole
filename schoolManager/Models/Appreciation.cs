namespace schoolManager.Models;

public class Appreciation : Eval
{
    private string appreciation;
    public Appreciation(string appreciation,Activite activite,List<Appreciation> listAppreciation,List<Eval> listEval):
    base(activite,listEval)
    {
        this.appreciation = appreciation;
        this.listAppreciation = listAppreciation;
        this.listAppreciation.Add(this);
    }
    public override int Note()
    {
        if (appreciation == "X"){return 20;}
        else if (appreciation == "TB"){return 16;}
        else if (appreciation == "B"){return 12;}
        else if (appreciation == "C"){return 8;}
        else if (appreciation == "N"){return 4;}
        else{return 0;}
    }
    public void setNote(string note)
    {
        appreciation = note;
    }
}
