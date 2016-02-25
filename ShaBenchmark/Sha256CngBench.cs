using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha256CngBench : BenchmarkBase
    {
        public Sha256CngBench(int count, int length) : base(count, length)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA256Cng();
        }
    }
}