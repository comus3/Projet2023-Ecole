namespace schoolManager.Models;

public class Enseignant : Person
{
    private int salaire;
    public List<Enseignant> listEnseignant;

    public Enseignant(int salaire,string firstName,string lastName,List<Enseignant> listEnseignant,List<Person> listPerson) :
    base(firstName,lastName,listPerson)
    {
        this.salaire = salaire;
        this.listEnseignant = listEnseignant;
        this.listEnseignant.Add(this);
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
