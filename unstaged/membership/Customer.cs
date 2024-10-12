using System.ComponentModel.DataAnnotations;

public class Customer
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int PhoneNumber { get; set; }

    public Customer()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
        PhoneNumber = 0;
    }

    public Customer(int id, string firstName, string lastName, int phoneNumber)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }
}