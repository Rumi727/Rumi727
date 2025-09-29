namespace RuniOS
{
    public struct BigQuaternion(BigComplex x, BigComplex y, BigComplex z, BigComplex w)
    {
        public BigComplex x { get; set; } = x;
        public BigComplex y { get; set; } = y;
        public BigComplex z { get; set; } = z;
        public BigComplex w { get; set; } = w;
    }
}
