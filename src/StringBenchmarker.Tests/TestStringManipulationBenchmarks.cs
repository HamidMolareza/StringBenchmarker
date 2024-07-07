namespace StringBenchmarker.Tests;

public class TestStringManipulationBenchmarks {
    private const string BaseString = "This is a text. ";
    private const int RepeatCount = 2;
    private const string ExpectedResult = $"{BaseString}{BaseString}";

    [Fact]
    public void StringConcatenation() {
        var benchmarks = new StringManipulationBenchmarks {
            RepeatCount = RepeatCount,
            BaseString = BaseString
        };

        var result = benchmarks.StringConcatenation();

        Assert.Equal(ExpectedResult, result);
    }

    [Fact]
    public void StringBuilderAppend() {
        var benchmarks = new StringManipulationBenchmarks {
            RepeatCount = RepeatCount,
            BaseString = BaseString
        };

        var result = benchmarks.StringBuilderAppend();

        Assert.Equal(ExpectedResult, result);
    }

    [Fact]
    public void StringInterpolation() {
        var benchmarks = new StringManipulationBenchmarks {
            RepeatCount = RepeatCount,
            BaseString = BaseString
        };

        var result = benchmarks.StringInterpolation();

        Assert.Equal(ExpectedResult, result);
    }

    [Fact]
    public void StringJoin() {
        var benchmarks = new StringManipulationBenchmarks {
            RepeatCount = RepeatCount,
            BaseString = BaseString
        };

        var result = benchmarks.StringJoin();

        Assert.Equal(ExpectedResult, result);
    }
}