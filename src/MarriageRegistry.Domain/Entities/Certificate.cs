namespace MarriageRegistry.Domain.Entities;

public class Certificate
{
    public Guid Id { get; private set; }

    public string CertificateNumber { get; private set; } = string.Empty;

    public string UniqueStamp { get; private set; } = string.Empty;

    public DateTime IssueDate { get; private set; }

    private Certificate()
    {
    }

    public Certificate(
        string certificateNumber,
        string uniqueStamp,
        DateTime issueDate)
    {
        Id = Guid.NewGuid();
        CertificateNumber = certificateNumber;
        UniqueStamp = uniqueStamp;
        IssueDate = issueDate;
    }
}