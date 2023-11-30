/* ToC Generator for TI.com
Version: v0.1

Scans folder and generate MD summarizing contents of interest, producing flat list.
*/

Import(Humanizer)
using System;
using System.Text;
using System.Text.RegularExpressions;

string[] ignoreFiles = new string[]
{
    "Toc.md",
    "README.md",
    "Index.md",
    "Index.html"
};
bool ShoudIgnoreFile(string file)
{
    string name = Path.GetFileName(file);
    return ignoreFiles.Contains(name)
        || name.StartsWith('.');
}
bool ShouldIgnoreDirectory(string path)
{
    return Path.GetFileName(path).StartsWith('.') 
        || Path.GetFileName(path).StartsWith('_');
}
void FormatLink(string file, string folderPath, out string fileName, out string relativeURL)
{
    fileName = Path.GetFileNameWithoutExtension(file);
    string relativePath = Path.GetRelativePath(folderPath, file);
    relativeURL = Regex.Replace(relativePath.Replace('\\', '/'), @"\.md$", string.Empty);
}

if (Arguments.Length == 0)
{
    WriteLine("""
    Not enough arguments.
    
    Usage:
      pure ToCGenerator <FolderPath> <OutputName>
    """);
    Environment.Exit(0);
}

string folderPath = Path.GetFullPath(Arguments.First());
string outputName = Arguments.Length > 1 ? Arguments[1] : "Toc.md";

StringBuilder builder = new();
builder.AppendLine("[↵Home](https://www.totalimagine.com/)");
builder.AppendLine();

if (Directory.EnumerateDirectories(folderPath).Count() == 0)
{
    string dirName = Path.GetFileName(folderPath);
    builder.AppendLine($"# {dirName}");
    builder.AppendLine();

    foreach (string file in Directory.EnumerateFiles(folderPath)
        .Where(file => !ShoudIgnoreFile(file)))
    {
        FormatLink(file, folderPath, out string fileName, out string relativeURL);
        builder.AppendLine($"* [{fileName.Humanize()}](./{relativeURL})");
    }
}
else
{
    foreach (string dir in Directory.EnumerateDirectories(folderPath)
        .Where(dir => !ShouldIgnoreDirectory(dir)))
    {
        string dirName = Path.GetFileName(dir);
        builder.AppendLine($"# {dirName}");
        builder.AppendLine();

        foreach (string file in Directory.EnumerateFiles(dir)
            .Where(file => !ignoreFiles.Contains(Path.GetFileName(file))))
        {
            FormatLink(file, folderPath, out string fileName, out string relativeURL);
            builder.AppendLine($"* [{fileName.Humanize()}](./{relativeURL})");
        }

        builder.AppendLine();
    }
}

string output = builder.ToString().Trim();
string outputPath = Path.Combine(folderPath, outputName);
WriteLine($"Writing to {outputPath}: ");
WriteLine(output);
File.WriteAllText(outputPath, output);