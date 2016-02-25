using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha1CngBench : BenchmarkBase
    {
        public Sha1CngBench(int count, int length) : base(count, length)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA1Cng();
        }
    }
}