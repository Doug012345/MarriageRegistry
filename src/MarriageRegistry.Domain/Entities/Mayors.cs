namespace MarriageRegistry.Domain.Entities;

public class Mayor
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    private Mayor()
    {
    }

    public Mayor(
        string firstName,
        string lastName)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
    }
}