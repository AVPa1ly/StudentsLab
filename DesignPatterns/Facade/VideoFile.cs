using System.IO;

namespace DesignPatterns.Facade
{
    class VideoFile
    {
        public string FileName { get; set; }

        public VideoFile(string fileName)
        {
            FileName = fileName;
        }

        public string GetExtension()
        {
            return Path.GetExtension(FileName);
        }
    }
}
