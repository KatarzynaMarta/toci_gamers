using System.Reflection;

namespace Toci.Teutons.Training
{
    public static class BenchmarkExtension
    {
        //extension method
        public static bool ContainsToLower(this Benchmark benchmark, string haystack, string needle)
        {
            //refleksja
            MethodInfo dupaMethod = benchmark.GetType().GetMethod("dupa", BindingFlags.NonPublic | BindingFlags.Instance);
            object dupaResult = dupaMethod.Invoke(benchmark, new object[] { benchmark });

            return benchmark.Contains(haystack.ToLower(), needle.ToLower());
        }
    }
}