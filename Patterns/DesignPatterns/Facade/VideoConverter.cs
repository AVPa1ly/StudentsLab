using System;
using System.IO;

namespace DesignPatterns.Facade
{
    public class VideoConverter
    {
        public static void Convert(VideoFile file, Codec codec)
        {
            codec.Encode(file);
            string destPath = Path.ChangeExtension(file.fileName, codec.extention.ToString().ToLower());
            Console.WriteLine("Encoded file path: {0}", destPath);
        }
    }
}
