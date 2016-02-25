using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha1ManagedBench : BenchmarkBase
    {
        public Sha1ManagedBench(int count, int length) : base(count, length)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA1Managed();
        }
    }
}