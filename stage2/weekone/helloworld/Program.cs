namespace helloworld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        UserName user = new UserName(firstName, lastName, age);
        Console.WriteLine(user);
    }
}

public class UserName
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public UserName()
    {
        FirstName = "";
        LastName = "";
        Age = 0;
    }

    public UserName(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}, Last Name: {LastName}, Age: {Age}";
    }
}
