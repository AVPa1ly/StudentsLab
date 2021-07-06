namespace DesignPatterns.Facade
{
    class Client : IClient
    {
        public void ShowPattern()
        {
            SimpleConverter converter = new SimpleConverter();
            converter.Convert("song.flac", "ogg");
            System.Console.WriteLine();
            converter.Convert("video.webm", "mp4");
        }
    }
}
