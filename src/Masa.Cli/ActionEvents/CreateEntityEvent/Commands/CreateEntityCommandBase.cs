using System.IO;

namespace Masa.Cli.ActionEvents.CreateEntityEvent.Commands;

public abstract record CreateEntityCommandBase : Event
{
    public string GetCsprojFileName()
    {
        var files = Directory.GetFiles("./", "*.csproj");
        if (files == null || files.Length < 1)
        {
            return null;
        }
        var file = files.First();
        return Path.GetFileNameWithoutExtension(file);
    }
}
