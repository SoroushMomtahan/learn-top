﻿using LearnTop.Modules.Academy.Domain.Tickets.ViewModels;

namespace LearnTop.Modules.Academy.Domain.Tickets.Repositories;

public interface ITicketViewRepository
{
    List<TicketView> FindAll(int pageIndex, int pageSize);
    Task AddAsync(TicketView ticketView);
    void UpdateAsync(TicketView ticketView);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
