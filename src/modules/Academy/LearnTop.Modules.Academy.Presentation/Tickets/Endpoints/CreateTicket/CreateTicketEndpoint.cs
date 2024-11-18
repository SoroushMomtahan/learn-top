using LearnTop.Modules.Academy.Application.Tickets.Commands.CreateTicket;
using LearnTop.Modules.Academy.Presentation.Abstractions.ApiResults;
using LearnTop.Shared.Domain;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace LearnTop.Modules.Academy.Presentation.Tickets.Endpoints.CreateTicket;

public static class CreateTicketEndpoint
{
    public static void Endpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("tickets", async (CreateTicketRequest request, ISender sender) =>
        {
            CreateTicketCommand command = request.Adapt<CreateTicketCommand>();
            Result<CreateTicketResult> result = await sender.Send(command);
            Result<CreateTicketResponse> response = result.Adapt<Result<CreateTicketResponse>>();
            return response.Match(Results.Ok, ApiResults.Problem);
        });
    }
}
