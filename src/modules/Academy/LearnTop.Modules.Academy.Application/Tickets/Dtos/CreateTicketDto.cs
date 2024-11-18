using LearnTop.Modules.Academy.Domain.Tickets.Enums;

namespace LearnTop.Modules.Academy.Application.Tickets.Dtos;

public record CreateTicketDto
    (
        Guid UserId, 
        string Title, 
        string Content, 
        TicketStatus Status,
        TicketPriority Priority, 
        TicketSection Section
        );
