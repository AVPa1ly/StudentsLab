namespace DesignPatterns.Facade
{
    public abstract class Codec
    {
        protected readonly int maxBitrate;

        protected readonly Algorythm encodingAlgorythm;

        public readonly Extention extention;

        public Codec(int maxBitrate, Algorythm encodingAlgorythm, Extention extention)
        {
            this.maxBitrate = maxBitrate;
            this.encodingAlgorythm = encodingAlgorythm;
            this.extention = extention;
        }

        public abstract void Encode(VideoFile file);
    }
}
