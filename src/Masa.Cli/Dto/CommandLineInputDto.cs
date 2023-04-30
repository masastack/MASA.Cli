using System.Diagnostics.CodeAnalysis;

namespace Masa.Cli.Dto;

public class CommandLineInputDto
{
    public string Action { get; }

    public string Target { get; }

    [NotNull]
    public Dictionary<string, string> Args { get; }

    public CommandLineInputDto(string action = null, string target = null)
    {
        Action = action;
        Target = target;
        Args = new Dictionary<string, string>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        if (Action != null)
        {
            sb.AppendLine($"Action: {Action}");
        }

        if (Target != null)
        {
            sb.AppendLine($"Target: {Target}");
        }

        if (Args.Any())
        {
            sb.AppendLine("Args:");
            foreach (var option in Args)
            {
                sb.AppendLine($" - {option.Key} = {option.Value}");
            }
        }

        if (sb.Length <= 0)
        {
            sb.Append("Empty");
        }

        return sb.ToString();
    }
}
