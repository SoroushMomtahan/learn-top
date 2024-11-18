using LearnTop.Shared.Domain;

namespace LearnTop.Modules.Academy.Domain.Tickets.Events;

public class TicketCreatedEvent(Guid ticketId) : DomainEvent
{
    public Guid TicketId { get; set; } = ticketId;
}
