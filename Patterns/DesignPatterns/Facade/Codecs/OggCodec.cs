using System;

namespace DesignPatterns.Facade
{
    public class OggCodec : Codec
    {
        public OggCodec(int maxBitrate, Algorythm encodingAlgorythm) : base(maxBitrate, encodingAlgorythm, Extention.Ogg)
        {
        }

        public override void Encode(VideoFile file)
        {
            Console.WriteLine("Proposed to encode {0} from the format {1} into OGG...", file.fileName, file.GetExtension());
            Console.WriteLine("Encoding using {0} algorythm with maximum bitrate of {1}", encodingAlgorythm.ToString(), maxBitrate);
        }
    }
}
