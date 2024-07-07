using System.Text;
using BenchmarkDotNet.Attributes;

namespace StringBenchmarker;

[MemoryDiagnoser] //Allows us to track the number of bytes assigned and the frequency of garbage collection.
public class StringManipulationBenchmarks {
    public string BaseString { get; set; } = "BenchmarkDotNet is a powerful .NET library for benchmarking your code.";

    [Params(10, 100, 1000)] public int RepeatCount { get; set; }

    [Benchmark]
    public string StringConcatenation() {
        var result = string.Empty;
        for (var i = 0; i < RepeatCount; i++) {
            result += BaseString;
        }

        return result;
    }

    [Benchmark]
    public string StringBuilderAppend() {
        var stringBuilder = new StringBuilder();
        for (var i = 0; i < RepeatCount; i++) {
            stringBuilder.Append(BaseString);
        }

        return stringBuilder.ToString();
    }

    [Benchmark]
    public string StringInterpolation() {
        var result = string.Empty;
        for (var i = 0; i < RepeatCount; i++) {
            result = $"{result}{BaseString}";
        }

        return result;
    }

    [Benchmark]
    public string StringJoin() {
        var strings = Enumerable.Range(0, RepeatCount)
            .Select(_ => BaseString).ToList();

        return string.Join(string.Empty, strings);
    }
}