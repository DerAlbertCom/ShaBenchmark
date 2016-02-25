using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Md5CngBench : BenchmarkBase
    {
        public Md5CngBench(int count, int length) : base(count, length)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new MD5Cng();
        }
    }
}