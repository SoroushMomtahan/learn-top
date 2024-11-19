using LearnTop.Modules.Academy.Domain.Tickets.Enums;

namespace LearnTop.Modules.Academy.Application.Tickets.Dtos;

public record TicketDto(
    Guid UserId,
    string Title,
    string Content,
    TicketStatus Status,
    TicketPriority Priority,
    TicketSection Section,
    List<ReplyTicketDto> ReplyTicketDtos
    );
