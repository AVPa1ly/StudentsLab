using System;

namespace DesignPatterns.Facade
{
    class Mpeg4Codec : Codec
    {
        public Mpeg4Codec(int bitrate = 320, Algorythm algo = Algorythm.DWT) : base(bitrate, algo, ".mp4")
        {
        }

        public override void Encode(VideoFile file)
        {
            Console.WriteLine("Proposed to encode {0} from the format {1} into MPEG4...", file.FileName, file.GetExtension());
            Console.WriteLine("Encoding using {0} algorythm with maximum bitrate of {1}", EncodingAlgo.ToString(), MaxBitrate);
        }
    }
}
