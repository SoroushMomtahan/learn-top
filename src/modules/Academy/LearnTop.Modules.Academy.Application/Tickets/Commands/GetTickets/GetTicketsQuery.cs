using LearnTop.Shared.Application.Cqrs;
using LearnTop.Shared.Application.Pagination;

namespace LearnTop.Modules.Academy.Application.Tickets.Commands.GetTickets;

public sealed record GetTicketsQuery(PaginationRequest PaginationRequest) : IQuery<GetTicketsResult>;
