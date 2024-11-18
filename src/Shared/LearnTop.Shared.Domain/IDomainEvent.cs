namespace LearnTop.Shared.Domain;

public interface IDomainEvent
{
    public Guid Id { get; }
    public DateTime OccuredOn { get; }
}
