using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha256CngBench : BenchmarkBase
    {
        public Sha256CngBench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA256Cng();
        }
    }
}