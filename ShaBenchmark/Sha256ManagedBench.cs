using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha256ManagedBench : BenchmarkBase
    {
        public Sha256ManagedBench(int count, int length) : base(count, length)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA256Managed();
        }
    }
}