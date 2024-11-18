namespace LearnTop.Shared.Domain;

public abstract class Aggregate : Entity
{
    private readonly List<DomainEvent> _domainEvents = [];
    public IReadOnlyList<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(DomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void Clear()
    {
        _domainEvents.Clear();
    }
}
