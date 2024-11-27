using LearnTop.Shared.Domain;
using MediatR;

namespace LearnTop.Modules.Academy.Domain.Tickets.Events;

public class TicketCreatedEvent(Ticket ticket) : DomainEvent
{
    public Ticket Ticket { get; set; } = ticket;
}
