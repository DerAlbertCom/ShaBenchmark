using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha1Bench : BenchmarkBase
    {
        public Sha1Bench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA1Managed();
        }
    }
}