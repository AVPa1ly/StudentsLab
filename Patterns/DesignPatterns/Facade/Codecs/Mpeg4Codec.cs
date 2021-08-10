using System;

namespace DesignPatterns.Facade
{
    public class Mpeg4Codec : Codec
    {
        public Mpeg4Codec(int maxBitrate, Algorythm encodingAlgorythm) : base(maxBitrate, encodingAlgorythm, Extention.Mp4)
        {
        }

        public override void Encode(VideoFile file)
        {
            Console.WriteLine("Proposed to encode {0} from the format {1} into MPEG4...", file.fileName, file.GetExtension());
            Console.WriteLine("Encoding using {0} algorythm with maximum bitrate of {1}", encodingAlgorythm.ToString(), maxBitrate);
        }
    }
}
