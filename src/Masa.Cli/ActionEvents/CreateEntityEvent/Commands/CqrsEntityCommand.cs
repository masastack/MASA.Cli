namespace Masa.Cli.ActionEvents.CreateEntityEvent.Commands;

[DisplayName("cqrs")]
public record CqrsEntityCommand : CreateEntityCommandBase
{
    public CqrsEntityCommand(CommandLineInputDto CommandLine) : base(CommandLine)
    {
    }
}
