using LearnTop.Shared.Domain;
using MediatR;

namespace LearnTop.Shared.Application.Cqrs;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>{}

public interface ICommand : IRequest<Result>{}
