using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    class OggCodec : Codec
    {
        public OggCodec(int bitrate = 120, Algorythm algo = Algorythm.DCT) : base(bitrate, algo, ".ogg")
        {
        }

        public override void Encode(VideoFile file)
        {
            Console.WriteLine("Proposed to encode {0} from the format {1} into OGG...", file.FileName, file.GetExtension());
            Console.WriteLine("Encoding using {0} algorythm with maximum bitrate of {1}", EncodingAlgo.ToString(), MaxBitrate);
        }
    }
}
