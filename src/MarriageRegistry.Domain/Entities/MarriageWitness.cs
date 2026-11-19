namespace MarriageRegistry.Domain.Entities;

public class MarriageWitness
{
    public Guid Id { get; private set; }

    public Guid MarriageId { get; private set; }

    public Guid PersonId { get; private set; }

    private MarriageWitness()
    {
    }

    public MarriageWitness(
        Guid marriageId,
        Guid personId)
    {
        Id = Guid.NewGuid();
        MarriageId = marriageId;
        PersonId = personId;
    }
}