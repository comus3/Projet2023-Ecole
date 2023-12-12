namespace schoolManager.Models;

public class Activite
{
    public int ECTS;
    public string Name;
    public string Code;
    public Enseignant enseignant;
    public Activite(string Name,string Code,Enseignant enseignant,int ECTS)
    {
        this.Name = Name;
        this.Code = Code;
        this.enseignant = enseignant;
        this.ECTS = ECTS;
    }
    

}
