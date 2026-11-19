namespace MarriageRegistry.Domain.Entities;

public class Marriage
{
    private readonly List<MarriageWitness> _witnesses = [];
    public IReadOnlyCollection<MarriageWitness> Witnesses =>
    _witnesses.AsReadOnly();
    public Guid Id { get; private set; }

    public string CertificateNumber { get; private set; } = string.Empty;

    public DateTime MarriageDate { get; private set; }

    public Guid CommuneId { get; private set; }

    public Guid MayorId { get; private set; }

    public Guid HusbandId { get; private set; }

public Guid WifeId { get; private set; }

    private Marriage()
    {
    }

    public Marriage(
        string certificateNumber,
        DateTime marriageDate,
        Guid communeId,
        Guid mayorId,
        Guid husbandId,
        Guid wifeId)
    {
        Id = Guid.NewGuid();
        CertificateNumber = certificateNumber;
        MarriageDate = marriageDate;
        CommuneId = communeId;
        MayorId = mayorId;
        HusbandId = husbandId;
        WifeId = wifeId;
    }

    public void AddWitness(Guid personId)
{
    if (_witnesses.Count >= 4)
    {
        throw new InvalidOperationException(
            "Maximum 4 witnesses allowed.");
    }

    _witnesses.Add(
        new MarriageWitness(
            Id,
            personId));
}
}