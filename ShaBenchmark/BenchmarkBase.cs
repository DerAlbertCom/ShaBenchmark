using System;
using System.Security.Cryptography;
using System.Text;

namespace ShaBenchmark
{
    public abstract class BenchmarkBase
    {
        private readonly int count;

        protected BenchmarkBase(int count)
        {
            this.count = count;
        }

        protected abstract HashAlgorithm GetHashAlgorithm();

        public void Run(bool once)
        {
            var hash = GetHashAlgorithm();
            if (once)
            {
                GetHash(hash);
            }
            else
            {
                for (int i = 0; i < this.count; i++)
                {
                    GetHash(hash);
                }
            }
        }

        private static void GetHash(HashAlgorithm hash)
        {
            var str = Guid.NewGuid().ToString() + Guid.NewGuid().ToString() + Guid.NewGuid().ToString()  + Guid.NewGuid().ToString();
            hash.ComputeHash(Encoding.UTF8.GetBytes(str));
        }
    }
}