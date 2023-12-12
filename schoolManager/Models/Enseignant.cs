namespace schoolManager;

public class Enseignant : Person
{
    private int salaire;
    public Enseignant(int salaire,string firstName,string lastName) :
    base(firstName,lastName)
    {
        this.salaire = salaire;
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
