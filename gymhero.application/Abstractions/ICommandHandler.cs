namespace GymHero.Application.Abstractions;

public interface ICommandHandler<TCommand> where TCommand : class, ICommand
{
    Task HandleAsync(TCommand command);
}