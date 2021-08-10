using System.IO;

namespace DesignPatterns.Facade
{
    public class VideoFile
    {
        public readonly string fileName;

        public VideoFile(string fileName)
        {
            this.fileName = fileName;
        }

        public string GetExtension()
        {
            return Path.GetExtension(fileName);
        }
    }
}
