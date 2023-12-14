namespace schoolManager.Models;

public class Activite
{
    public int ECTS;
    public string Name;
    public string Code;
    public Enseignant enseignant;
    public List<Activite> listActivite;
    public Activite(string Name,string Code,Enseignant enseignant,int ECTS,List<Activite> listActivite)
    {
        this.Name = Name;
        this.Code = Code;
        this.enseignant = enseignant;
        this.ECTS = ECTS;
        this.listActivite = listActivite;
        this.listActivite.Add(this);
    }
    

}
