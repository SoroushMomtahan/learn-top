using LearnTop.Modules.Academy.Domain.Tickets.ViewModels;
using LearnTop.Modules.Academy.Infrastructure.Database.WriteDb;
using Microsoft.EntityFrameworkCore;

namespace LearnTop.Modules.Academy.Infrastructure.Database.ReadDb;

public class AcademyViewDbContext(DbContextOptions<AcademyViewDbContext> options) : DbContext(options)
{
    public DbSet<TicketView> TicketViews { get; set; }
    
}
