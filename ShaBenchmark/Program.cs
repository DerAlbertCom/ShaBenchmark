using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShaBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            const int warmUp = 1000;
            BenchIt(new Sha256Bench(warmUp));
            BenchIt(new Sha1Bench(warmUp));
            BenchIt(new Md5Bench(warmUp));
            const int benchCount = 500000;
            BenchIt(new Sha256Bench(benchCount));
            BenchIt(new Sha1Bench(benchCount));
            BenchIt(new Md5Bench(benchCount));
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