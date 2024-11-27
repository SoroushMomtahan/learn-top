using MediatR;

namespace LearnTop.Shared.Domain;

public interface IDomainEvent : INotification
{
    public Guid Id { get; }
    public DateTime OccuredOn { get; }
}
