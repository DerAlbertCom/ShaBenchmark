using System;
using System.Diagnostics;

namespace ShaBenchmark
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            const int warmUp = 100;
            BenchItAll(warmUp, 16);
            const int benchCount = 500000;
            for (int i = 32; i < 540; i += 32)
            {
                BenchItAll(benchCount, i);
            }
        }

        private static void BenchItAll(int count, int length)
        {
            BenchIt(new Sha256ManagedBench(count, length), count, length);
            BenchIt(new Sha256CryptoServiceProviderBench(count, length), count, length);
            BenchIt(new Sha256CngBench(count, length), count, length);
            BenchIt(new Sha1ManagedBench(count, length), count, length);
            BenchIt(new Sha1CryptoServiceProviderBench(count, length), count, length);
            BenchIt(new Sha1CngBench(count, length), count, length);
            BenchIt(new Md5Bench(count, length), count, length);
            BenchIt(new Md5CryptoServiceProviderBench(count, length), count, length);
            BenchIt(new Md5CngBench(count, length), count, length);
        }

        private static void BenchIt(BenchmarkBase benchmark, int count, int length)
        {
            var sw = new Stopwatch();
            benchmark.Run(true);
            sw.Start();
            benchmark.Run(false);
            sw.Stop();

            if (count > 100) // dont show warmup
            {
                //Console.WriteLine("{2,7} Hashes of {3,5}chars with {0,32} needs {1,7}ms", benchmark.GetType().Name,
                //    sw.ElapsedMilliseconds, count, length);
                Console.WriteLine("{0},{2},{3},{1}", benchmark.GetType().Name, sw.ElapsedMilliseconds, count, length);
            }
        }
    }
}