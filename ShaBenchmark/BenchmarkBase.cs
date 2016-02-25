using System;
using System.Security.Cryptography;
using System.Text;

namespace ShaBenchmark
{
    public abstract class BenchmarkBase
    {
        private readonly int count;
        private readonly byte[] bytes;

        protected BenchmarkBase(int count, int length)
        {
            this.count = count;
            this.bytes = CreateBytes(length);
        }

        private byte[] CreateBytes(int length)
        {
            return Encoding.UTF8.GetBytes(RandomString(length));
        }

        private string RandomString(int size)
        {
            var builder = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26*random.NextDouble() + 65))));
            }

            return builder.ToString();
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
                for (int i = 0; i < count; i++)
                {
                    GetHash(hash);
                }
            }
        }

        private void GetHash(HashAlgorithm hash)
        {
            hash.ComputeHash(bytes);
        }
    }
}