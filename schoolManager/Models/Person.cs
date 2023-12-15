namespace schoolManager.Models
{
    public class Person
    {
        private readonly string firstName;
        private readonly string lastName;
        private static List<Person> listPerson = new List<Person>();

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            listPerson.Add(this);
        }

        public string DisplayName()
        {
            return firstName + " " + lastName;
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public static List<Person> ListPerson
        {
            get { return listPerson; }
        }
    }
}
