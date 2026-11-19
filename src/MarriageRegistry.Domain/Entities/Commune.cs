namespace MarriageRegistry.Domain.Entities;

public class Commune
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    private Commune()
    {
    }

    public Commune(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}