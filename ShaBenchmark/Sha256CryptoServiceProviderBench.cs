using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Sha256CryptoServiceProviderBench : BenchmarkBase
    {
        public Sha256CryptoServiceProviderBench(int count, int length) : base(count, length)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new SHA256CryptoServiceProvider();
        }
    }
}