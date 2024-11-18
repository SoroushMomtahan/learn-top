using FluentValidation;
using LearnTop.Modules.Academy.Application;
using LearnTop.Modules.Academy.Domain.Tickets.Repositories;
using LearnTop.Modules.Academy.Infrastructure.database;
using LearnTop.Modules.Academy.Infrastructure.database.Repositories;
using LearnTop.Modules.Academy.Presentation.Tickets.Endpoints.CreateTicket;
using LearnTop.Shared.Application.Data;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LearnTop.Modules.Academy.Infrastructure;

public static class AcademyModule
{
    public static void MapEndpoints(IEndpointRouteBuilder app)
    {
        CreateTicketEndpoint.Endpoint(app);
    }
    public static IServiceCollection AddAcademyModule(
            this IServiceCollection services,
            IConfiguration configuration)
    {
        services.AddInfrastructure(configuration);
        
        return services;
    }
    
    private static void AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<ITicketRepository, TicketRepository>();
        services.AddScoped<IUnitOfWork>(sp=>sp.GetRequiredService<AcademyDbContext>());
        services.AddDbContext<AcademyDbContext>(sp =>
        {
            string connectionString = configuration.GetConnectionString("")!;
            sp.UseSqlServer(connectionString);
        });
    }
}
