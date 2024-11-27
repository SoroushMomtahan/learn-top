﻿using LearnTop.Modules.Academy.Domain.Tickets;
using LearnTop.Modules.Academy.Domain.Tickets.Events;
using LearnTop.Modules.Academy.Domain.Tickets.Repositories;
using LearnTop.Modules.Academy.Domain.Tickets.ViewModels;
using MediatR;

namespace LearnTop.Modules.Academy.Application.Tickets.EventHandlers;

public class TicketCreatedEventHandler(
    ITicketViewRepository ticketViewRepository)
    : INotificationHandler<TicketCreatedEvent>
{
    public async Task Handle(TicketCreatedEvent notification, CancellationToken cancellationToken)
    {
        Ticket ticket = notification.Ticket;
        var ticketView = new TicketView
        {
            Id = ticket.Id,
            UserId = ticket.UserId,
            Title = ticket.Title,
            Content = ticket.Content,
            Priority = ticket.Priority.ToString(),
            Status = ticket.Status.ToString(),
            Section = ticket.Section.ToString()
        };
        await ticketViewRepository.AddAsync(ticketView);
        await ticketViewRepository.SaveChangesAsync(cancellationToken);
    }
}
