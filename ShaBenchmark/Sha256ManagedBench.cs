using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha256ManagedBench : BenchmarkBase
    {
        public Sha256ManagedBench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA256Managed();
        }
    }
}