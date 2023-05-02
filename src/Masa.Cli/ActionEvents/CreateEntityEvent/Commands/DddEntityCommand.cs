namespace Masa.Cli.ActionEvents.CreateEntityEvent.Commands;

[DisplayName("ddd")]
public record DddEntityCommand : CreateEntityCommandBase
{
    public DddEntityCommand(CommandLineInputDto commandLine) : base(commandLine)
    {
    }
}
