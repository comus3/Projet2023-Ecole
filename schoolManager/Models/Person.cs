namespace seance2;

public class Person
{
    private readonly string firstName;
    private readonly string lastName;
    public Person(string firstName,string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public string displayName()
    {
        return firstName + " " + lastName;
    }
    public string FirstName
    {
        get {
            return firstName;
        }
    }
    public string LasttName
    {
        get {
            return lastName;
        }
    }
}
