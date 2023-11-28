/* ToC Generator for TI.com
Version: v0.1

Scans folder and generate MD summarizing contents of interest, producing flat list.
*/

Import(Humanizer)
using System.Text;
using System.Text.RegularExpressions;

string folderPath = Path.GetFullPath(Arguments.First());

StringBuilder builder = new();
builder.AppendLine("[↵Home](https://www.totalimagine.com/)");
builder.AppendLine();

foreach (string dir in Directory.EnumerateDirectories(folderPath))
{
    string dirName = Path.GetFileName(dir);
    builder.AppendLine($"# {dirName}");
    builder.AppendLine();

    foreach (string file in Directory.EnumerateFiles(dir))
    {
        string fileName = Path.GetFileNameWithoutExtension(file);
        string relativePath = Path.GetRelativePath(folderPath, file);
        string relativeURL = Regex.Replace(relativePath.Replace('\\', '/'), @"\.md$", string.Empty);
        builder.AppendLine($"* [{fileName.Humanize()}](./{relativeURL})");
    }

    builder.AppendLine();
}

string output = builder.ToString().Trim();
string outputPath = Path.Combine(folderPath, "ToC.md");
WriteLine(output);
File.WriteAllText(outputPath, output);