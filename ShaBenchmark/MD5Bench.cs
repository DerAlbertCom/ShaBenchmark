using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Md5Bench : BenchmarkBase
    {
        public Md5Bench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new MD5CryptoServiceProvider();
        }
    }
}