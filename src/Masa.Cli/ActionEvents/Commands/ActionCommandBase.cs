namespace Masa.Cli.ActionEvents.Commands;

public abstract record ActionCommandBase(string[] Args) : Event
{
    public CommandLineInputDto GetCommandLineArgs()
    {
        string[] args = Args;
        if (args.IsNullOrEmpty())
        {
            return new CommandLineInputDto();
        }

        var argumentList = args.ToList();

        //Action
        var command = argumentList[0];
        argumentList.RemoveAt(0);

        if (!argumentList.Any())
        {
            return new CommandLineInputDto(command);
        }

        //Target
        var target = argumentList[0];
        if (target.StartsWith("-"))
        {
            target = null;
        }
        else
        {
            argumentList.RemoveAt(0);
        }

        if (!argumentList.Any())
        {
            return new CommandLineInputDto(command, target);
        }

        //Arguments
        var commandLineArgs = new CommandLineInputDto(command, target);
        while (argumentList.Any())
        {
            var optionName = ParseArgName(argumentList[0]);
            argumentList.RemoveAt(0);

            if (!argumentList.Any())
            {
                commandLineArgs.Args[optionName] = null;
                break;
            }

            if (IsArgName(argumentList[0]))
            {
                commandLineArgs.Args[optionName] = null;
                continue;
            }

            commandLineArgs.Args[optionName] = argumentList[0];
            argumentList.RemoveAt(0);
        }

        return commandLineArgs;
    }

    private bool IsArgName(string argName)
    {
        return argName.StartsWith("-") || argName.StartsWith("--");
    }

    private string ParseArgName(string argument)
    {
        if (argument.StartsWith("--"))
        {
            if (argument.Length <= 2)
            {
                throw new ArgumentException("Should specify an argument name after '--' prefix!");
            }

            return argument.TrimStart("--");
        }

        if (argument.StartsWith("-"))
        {
            if (argument.Length <= 1)
            {
                throw new ArgumentException("Should specify an argument name after '--' prefix!");
            }

            return argument.TrimStart("-");
        }

        throw new ArgumentException("Argument names should start with '-' or '--'.");
    }
}
