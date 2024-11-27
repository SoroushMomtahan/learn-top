using LearnTop.Modules.Academy.Application.Tickets.Dtos;
using LearnTop.Shared.Application.Pagination;
using LearnTop.Shared.Domain;

namespace LearnTop.Modules.Academy.Presentation.Tickets.Endpoints.GetTickets;

public record GetTicketResponse(Result<PaginatedResult<TicketDto>> Result);
