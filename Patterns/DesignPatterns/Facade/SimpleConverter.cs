namespace DesignPatterns.Facade
{
    public class SimpleConverter
    {
        public void Convert(string filename, Extention format)
        {
            VideoFile file = new VideoFile(filename);
            Codec codec;
            if (format == Extention.Ogg)
            {
                codec = new OggCodec(128, Algorythm.DCT);
            }
            else
            {
                codec = new Mpeg4Codec(320, Algorythm.DWT);
            }
            VideoConverter.Convert(file, codec);
        }
    }
}
