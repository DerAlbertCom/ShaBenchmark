﻿using System;
using System.Diagnostics;

namespace ShaBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            const int warmUp = 1000;
            BenchItAll(warmUp);
            const int benchCount = 500000;
            BenchItAll(benchCount);
        }

        private static void BenchItAll(int count)
        {
            BenchIt(new Sha256Bench(count));
            BenchIt(new Sha256CryptoServiceProviderBench(count));
            BenchIt(new Sha1Bench(count));
            BenchIt(new Sha1CryptoServiceProviderBench(count));
            BenchIt(new Md5Bench(count));
            BenchIt(new Md5CryptoServiceProviderBench(count));
        }

        private static void BenchIt(BenchmarkBase benchmark)
        {
            var sw = new Stopwatch();
            benchmark.Run(true);
            sw.Start();
            benchmark.Run(false);
            sw.Stop();
            Console.WriteLine("{0},{1}",benchmark.GetType().Name,sw.ElapsedMilliseconds);
        }
    }
}