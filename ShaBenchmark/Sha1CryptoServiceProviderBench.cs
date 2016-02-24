using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha1CryptoServiceProviderBench : BenchmarkBase
    {
        public Sha1CryptoServiceProviderBench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA1CryptoServiceProvider();
        }
    }
}