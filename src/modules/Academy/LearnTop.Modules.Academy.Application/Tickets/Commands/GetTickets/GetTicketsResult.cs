using LearnTop.Modules.Academy.Application.Tickets.Dtos;
using LearnTop.Shared.Application.Pagination;

namespace LearnTop.Modules.Academy.Application.Tickets.Commands.GetTickets;

public sealed record GetTicketsResult(PaginatedResult<TicketDto> TicketDtos);
