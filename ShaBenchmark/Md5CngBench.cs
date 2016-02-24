using System.Security.Cryptography;

namespace ShaBenchmark
{
    public class Md5CngBench : BenchmarkBase
    {
        public Md5CngBench(int count) : base(count)
        {
        }

        protected override HashAlgorithm GetHashAlgorithm()
        {
            return new MD5Cng();
        }
    }
}