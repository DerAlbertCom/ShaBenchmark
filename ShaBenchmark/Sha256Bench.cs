using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha256Bench : BenchmarkBase
    {
        public Sha256Bench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return SHA256.Create();
        }
    }
}