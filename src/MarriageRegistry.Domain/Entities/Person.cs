namespace MarriageRegistry.Domain.Entities;
using MarriageRegistry.Domain.Enums;

public class Person
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public int Age { get; private set; }
    
    public PersonRole Role { get; private set; }
    private Person()
    {
    }

    public Person(
        string firstName,
        string lastName,
        int age,
        PersonRole role)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException(
            "First name is required.");
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException(
            "Last name is required.");
        }

        if (age < 18)
        {
            throw new ArgumentException(
            "Person must be at least 18 years old.");
        }

        Id = Guid.NewGuid();

        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Role = role;
    }
}