using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha1CryptoServiceProviderBench : BenchmarkBase
    {
        public Sha1CryptoServiceProviderBench(int count, int length) : base(count, length)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA1CryptoServiceProvider();
        }
    }
}