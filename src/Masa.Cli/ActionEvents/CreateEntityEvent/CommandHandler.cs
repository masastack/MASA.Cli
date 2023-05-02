using Masa.Cli.ActionEvents.CreateEntityEvent.Commands;
using System.IO;

namespace Masa.Cli.ActionEvents.CreateEntityEvent;

public class CommandHandler
{
    [EventHandler]
    public async Task CreateCqrsEntity(CqrsEntityCommand @event)
    {
        var commandLine = @event.CommandLine;
        var projectNameSpace = @event.GetCsprojFileName();

        if (commandLine.Args.TryGetValue(CliConsts.CreateEntity.ProjectNameCommandKey, out string projectName) && !projectName.IsNullOrEmpty())
        {
            projectNameSpace = projectName;
        }
        projectNameSpace = projectNameSpace.IsNullOrEmpty() ? "" : $"{projectNameSpace.Trim('.')}.";

        List<Tuple<string, string>> replaceStrs = new List<Tuple<string, string>>
        {
            new Tuple<string, string>(CliConsts.CreateEntity.ProjectNameSpaceKey, projectNameSpace),
            new Tuple<string, string>("CqrsEntity", commandLine.Target),
        };

        var files = @event.GetFilesByTemplate(replaceStrs.ToArray());

        foreach (var item in files)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), item.Key);
            FileHelper.CreateDirectory(filePath);
            Console.WriteLine(filePath);
            File.WriteAllText(filePath, item.Value, Encoding.UTF8);
        }

    }

    [EventHandler]
    public Task CreateDddEntity(DddEntityCommand @event)
    {
        throw new NotImplementedException();
    }
}
