namespace schoolManager.Models;

public class Enseignant : Person
{
    private int salaire;
    public List<Enseignant> listEnseignant;

    public Enseignant(int salaire,string firstName,string lastName,List<Enseignant> listEnseignant) :
    base(firstName,lastName)
    {
        this.salaire = salaire;
        listEnseignant.Add(this);
    }
    public void Raise(int amt)
    {
        salaire += amt;
    }
    public string ReturnSalary()
    {
        return salaire.ToString();
    }
}
