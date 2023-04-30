namespace Masa.Cli.ActionEvents.Commands;

[DisplayName("create-entity")]
public record CreateEntityCommand : ActionCommandBase
{
    public CreateEntityCommand(string[] Args) : base(Args)
    {
    }
}
