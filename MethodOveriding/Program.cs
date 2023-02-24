
internal class Program
{
    private static void Main(string[] args)
    {
        PersonModel david = new PersonModel {FirstName="David", LastName="Chuvik", Email="dchuvik@gmail.com", YearCreated=1999 };
        PersonModel karolina = new PersonModel { FirstName = "Karolina", LastName = "Gurulyova", Email = "kgurulyova@gmail.com", YearCreated = 1999 };
        PersonModel georgiy = new PersonModel{ FirstName = "Georgiy", LastName = "Chuvik", Email = "gchuvik1@gmail.com", YearCreated = 1963 };

        List<PersonModel> people = new List<PersonModel>();
        people.Add(david);
        people.Add(karolina);
        people.Add(georgiy);

        foreach (var person in people)
        {
            Console.WriteLine(person);
        }


    }
}

public abstract class Creature
{
    public int YearCreated { get; set; }
}

public class PersonModel : Creature
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}