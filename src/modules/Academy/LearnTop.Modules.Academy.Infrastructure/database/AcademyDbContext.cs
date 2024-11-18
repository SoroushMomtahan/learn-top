using LearnTop.Modules.Academy.Domain.Tickets;
using LearnTop.Shared.Application.Data;
using Microsoft.EntityFrameworkCore;

namespace LearnTop.Modules.Academy.Infrastructure.database;

public class AcademyDbContext(DbContextOptions<AcademyDbContext> options) : DbContext(options), IUnitOfWork
{
    public DbSet<Ticket> Tickets => Set<Ticket>();
    
}
