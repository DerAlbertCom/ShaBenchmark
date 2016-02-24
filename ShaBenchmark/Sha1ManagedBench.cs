using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha1ManagedBench : BenchmarkBase
    {
        public Sha1ManagedBench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA1Managed();
        }
    }
}