namespace LearnTop.Shared.Domain;

public abstract class Aggregate : Entity
{
    private readonly List<IDomainEvent> _domainEvents = [];
    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void Clear()
    {
        _domainEvents.Clear();
    }
}
