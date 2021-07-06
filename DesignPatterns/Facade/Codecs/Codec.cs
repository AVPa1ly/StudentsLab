namespace DesignPatterns.Facade
{
    enum Algorythm
    {
        DCT,
        DWT,
        VQ,
        Huffman
    }

    abstract class Codec
    {
        protected int MaxBitrate { get; set; }

        protected Algorythm EncodingAlgo { get; set; }

        public readonly string extension;

        public Codec(int bitrate, Algorythm algo, string fileExtension)
        {
            MaxBitrate = bitrate;
            EncodingAlgo = algo;
            extension = fileExtension;
        }

        public abstract void Encode(VideoFile file);
    }
}
