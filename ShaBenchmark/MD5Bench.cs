using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Md5Bench : BenchmarkBase
    {
        public Md5Bench(int count, int length) : base(count, length)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return MD5.Create();
        }
    }
}