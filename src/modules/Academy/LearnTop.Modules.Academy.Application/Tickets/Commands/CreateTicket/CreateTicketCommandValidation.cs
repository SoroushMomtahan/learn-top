using FluentValidation;

namespace LearnTop.Modules.Academy.Application.Tickets.Commands.CreateTicket;

internal sealed class CreateTicketCommandValidation : AbstractValidator<CreateTicketCommand>
{
    public CreateTicketCommandValidation()
    {
        RuleFor(t => t.CreateTicketDto.Title)
            .MinimumLength(3)
            .MaximumLength(20);
    }
}
