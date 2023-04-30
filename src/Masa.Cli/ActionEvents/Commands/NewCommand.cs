namespace Masa.Cli.ActionEvents.Commands;

public record NewCommand : ActionCommandBase
{
    public NewCommand(string[] Args) : base(Args)
    {
    }
}
