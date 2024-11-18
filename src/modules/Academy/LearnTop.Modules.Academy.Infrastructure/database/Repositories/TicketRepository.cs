using LearnTop.Modules.Academy.Domain.Tickets;
using LearnTop.Modules.Academy.Domain.Tickets.Repositories;

namespace LearnTop.Modules.Academy.Infrastructure.database.Repositories;

public class TicketRepository(
    AcademyDbContext dbContext
    )
    : ITicketRepository
{
    public async Task AddAsync(Ticket ticket)
    {
        await dbContext.Tickets.AddAsync(ticket);
    }

    public Task<Guid> UpdateAsync(Ticket ticket)
    {
        throw new NotImplementedException();
    }
}
