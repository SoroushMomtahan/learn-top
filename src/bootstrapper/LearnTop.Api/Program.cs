using LearnTop.Api.Extensions;
using LearnTop.Api.Middlewares;
using LearnTop.Modules.Academy.Infrastructure;
using LearnTop.Shared.Application;
using LearnTop.Shared.Infrastructure;
using Serilog;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddApplicationConfiguration(LearnTop.Modules.Academy.Application.AssemblyReference.AcademyAssembly)
    .AddInfrastructureConfiguration(builder.Configuration.GetConnectionString("Cache")!)
    .AddAcademyModule(builder.Configuration);

builder.Configuration.AddConfigurationFiles("academy");

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

AcademyModule.MapEndpoints(app);

app.UseSerilogRequestLogging();

app.UseExceptionHandler();

app.Run();
