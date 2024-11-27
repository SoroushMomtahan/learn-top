using LearnTop.Modules.Academy.Domain.Tickets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnTop.Modules.Academy.Infrastructure.Database.WriteDb.Configurations;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.Property(t => t.Priority).HasConversion<string>();
        builder.Property(t => t.Status).HasConversion<string>();
        builder.Property(t => t.Section).HasConversion<string>();
    }
}
