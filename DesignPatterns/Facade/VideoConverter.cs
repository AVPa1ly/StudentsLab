using System;
using System.IO;

namespace DesignPatterns.Facade
{
    class VideoConverter
    {
        public static void Convert(VideoFile file, Codec codec)
        {
            codec.Encode(file);
            string destPath = Path.ChangeExtension(file.FileName, codec.extension);
            Console.WriteLine("Encoded file path: {0}", destPath);
        }
    }
}
