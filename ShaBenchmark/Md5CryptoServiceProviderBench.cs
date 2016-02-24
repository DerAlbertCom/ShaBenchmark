using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Md5CryptoServiceProviderBench : BenchmarkBase
    {
        public Md5CryptoServiceProviderBench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new MD5CryptoServiceProvider();
        }
    }
}