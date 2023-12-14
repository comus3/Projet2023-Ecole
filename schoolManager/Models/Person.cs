namespace schoolManager.Models;

public class Person
{
    private readonly string firstName;
    private readonly string lastName;
    private static List<Person> listPerson;

    public Person(string firstName,string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        listPerson.Add(this);
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
    public static List<Person> getListPerson()
    {
        return listPerson;
    }
}
