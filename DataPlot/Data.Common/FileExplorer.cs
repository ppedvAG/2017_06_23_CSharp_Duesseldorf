using Data.Common.Interfaces;
using System.IO;

namespace Data.Common
{
    public class FileExplorer : IFileExplorer
    {
        public string GetFileExtention(string filePath)
        {
            return Path.GetExtension(filePath);
        }
    }
}
