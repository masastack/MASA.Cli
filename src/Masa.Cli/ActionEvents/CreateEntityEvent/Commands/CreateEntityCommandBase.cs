using System.IO;

namespace Masa.Cli.ActionEvents.CreateEntityEvent.Commands;

public abstract record CreateEntityCommandBase(CommandLineInputDto CommandLine) : Event
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns>File relative path and new file stream</returns>
    public IDictionary<string, string> GetFilesByTemplate(params Tuple<string, string>[] replaceStrs)
    {
        IDictionary<string, string> result = new Dictionary<string, string>();


        if (CommandLine.Args.TryGetValue(CliConsts.CreateEntity.ModeKey, out string modeValue) == false)
        {
            modeValue = "cqrs";
        }

        var rootDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CliConsts.TemplateDir, CommandLine.Action, modeValue);

        foreach (var itemFilePath in Directory.GetFiles(rootDirectory, "*", SearchOption.AllDirectories))
        {
            var fileContent = FileHelper.GetFileContent(itemFilePath, replaceStrs);

            var fileRelativePath = FileHelper.ReplaceFileName($".{itemFilePath.Replace(rootDirectory, "")}", replaceStrs);
            result[fileRelativePath] = fileContent;
        }
        return result;
    }
}
