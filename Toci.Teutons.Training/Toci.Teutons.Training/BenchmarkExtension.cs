namespace Toci.Teutons.Training
{
    public static class BenchmarkExtension
    {
        public static bool ContainsToLower(this Benchmark benchmark, string haystack, string needle)
        {
            return benchmark.Contains(haystack.ToLower(), needle.ToLower());
        }
    }
}