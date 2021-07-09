using System;

namespace DesignPatterns.Facade
{
    public class Client : IClient
    {
        public void ShowPattern()
        {
            SimpleConverter converter = new SimpleConverter();
            converter.Convert("song.flac", Extention.Ogg);
            Console.WriteLine();
            converter.Convert("video.webm", Extention.Mp4);
        }
    }
}
