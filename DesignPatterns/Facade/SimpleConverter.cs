namespace DesignPatterns.Facade
{
    class SimpleConverter
    {
        public void Convert(string filename, string format)
        {
            VideoFile file = new VideoFile(filename);
            Codec codec;
            if (format == "ogg")
            {
                codec = new OggCodec();
            }
            else
            {
                codec = new Mpeg4Codec();
            }
            VideoConverter.Convert(file, codec);
        }
    }
}
