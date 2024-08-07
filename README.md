<div align="center">
  <h1>StringBenchmarker</h1>
  <br />
  <a href="#results-and-analysis"><strong>Results and Analysis »</strong></a>
  <br />
  <br />
  <a href="https://github.com/HamidMolareza/StringBenchmarker/issues/new?assignees=&labels=bug&template=BUG_REPORT.md&title=bug%3A+">Report a Bug</a>
  ·
  <a href="https://github.com/HamidMolareza/StringBenchmarker/issues/new?assignees=&labels=enhancement&template=FEATURE_REQUEST.md&title=feat%3A+">Request a Feature</a>
  .
  <a href="https://github.com/HamidMolareza/StringBenchmarker/issues/new?assignees=&labels=question&template=SUPPORT_QUESTION.md&title=support%3A+">Ask a Question</a>
</div>

<div align="center">
<br />

![Build Status](https://github.com/HamidMolareza/StringBenchmarker/actions/workflows/build.yaml/badge.svg?branch=main)

![GitHub](https://img.shields.io/github/license/HamidMolareza/StringBenchmarker)
[![Pull Requests welcome](https://img.shields.io/badge/PRs-welcome-ff69b4.svg?style=flat-square)](https://github.com/HamidMolareza/StringBenchmarker/issues?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22)

</div>

## About

**StringBenchmarker** is a .NET console application that benchmarks various string manipulation methods using BenchmarkDotNet. This project provides performance comparisons for different approaches to string concatenation, including `string` concatenation, `StringBuilder`, string interpolation, and `string.Join`.

### What problem does it solve?
String manipulation is a common task in software development, and inefficient handling can lead to performance bottlenecks. This project aims to provide developers with insights into the performance implications of different string manipulation methods.

### Purpose
The primary purpose of StringBenchmarker is to offer a comprehensive performance analysis of various string concatenation techniques. By doing so, it helps developers make informed decisions when optimizing their code for better performance.

### Built With

- .NET 8

## Results and Analysis

```txt
BenchmarkDotNet v0.13.12, Ubuntu 24.04 LTS (Noble Numbat)  
Intel Core i7-3630QM CPU 2.40GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores  
.NET SDK 8.0.105
```

### Summary

The following table presents the performance benchmarks for different string manipulation methods using BenchmarkDotNet. Each method was tested with varying `RepeatCount` to analyze their execution times under different scenarios.

| Method              | RepeatCount | Mean            | Error         | StdDev        |
|---------------------|-------------|----------------:|--------------:|--------------:|
| StringConcatenation | 10          |      1,104.8 ns |       8.50 ns |       7.10 ns |
| StringBuilderAppend | 10          |        683.7 ns |       4.70 ns |       3.92 ns |
| StringInterpolation | 10          |      1,153.5 ns |       9.75 ns |       9.12 ns |
| StringJoin          | 10          |        441.7 ns |       2.13 ns |       1.89 ns |
| StringConcatenation | 100         |     86,986.1 ns |     767.66 ns |     680.51 ns |
| StringBuilderAppend | 100         |      4,984.9 ns |      36.73 ns |      30.67 ns |
| StringInterpolation | 100         |     90,462.2 ns |     615.41 ns |     575.66 ns |
| StringJoin          | 100         |      3,183.9 ns |      25.57 ns |      22.67 ns |
| StringConcatenation | 1000        | 11,378,172.7 ns | 132,579.60 ns | 124,015.04 ns |
| StringBuilderAppend | 1000        |    126,879.6 ns |     906.10 ns |     847.56 ns |
| StringInterpolation | 1000        | 11,204,105.4 ns |  73,616.35 ns |  65,258.98 ns |
| StringJoin          | 1000        |    101,853.2 ns |     520.53 ns |     486.90 ns |

### Analysis

- **StringConcatenation vs. StringBuilderAppend:** As `RepeatCount` increases, `StringBuilderAppend` consistently outperforms `StringConcatenation`, especially noticeable with larger repetitions (e.g., 1000).
- **StringInterpolation:** Shows competitive performance with `StringConcatenation` for smaller repetitions but exhibits significant slowdown with larger data sets (`RepeatCount` of 1000).
- **StringJoin:** Demonstrates the best performance across all scenarios, indicating its efficiency in concatenating strings.

#### Interpretation

- **Mean:** Represents the average execution time across multiple iterations.
- **StdDev (Standard Deviation):** Indicates the variability or dispersion of data points around the mean.
- **Error:** Margin of error for the mean value.

### Conclusion

- For small to medium-sized operations (`RepeatCount` <= 100), developers can choose between `StringBuilderAppend` and `StringJoin` for efficient string concatenation.
- For larger operations (`RepeatCount` = 1000), `StringJoin` emerges as the optimal choice due to its consistent performance and lower standard deviation.

These benchmarks provide valuable insights into choosing the most suitable string manipulation method based on performance requirements in .NET applications.

## Getting Started

To use this project, you can use Docker or .NET SDK 8.0. See [Getting Started](docs/Getting-Started.md) for more information.

## Files Structure

```txt
src
├── Dockerfile
├── StringBenchmarker
│   ├── Program.cs
│   ├── StringBenchmarker.csproj
│   └── StringManipulationBenchmarks.cs
├── StringBenchmarker.sln
└── StringBenchmarker.Tests
    ├── GlobalUsings.cs
    ├── StringBenchmarker.Tests.csproj
    └── TestStringManipulationBenchmarks.cs
```

## Features

StringBenchmarker offers the following features to analyze and optimize string manipulation performance in .NET applications:

- **Benchmark Different Methods**: Compare performance across various string manipulation techniques such as `StringConcatenation`, `StringBuilderAppend`, `StringInterpolation`, and `StringJoin`.

- **Customizable Parameters**: Easily adjust benchmark parameters such as the number of repetitions to simulate different scenarios and workload sizes.

- **Supports Docker**: Run benchmarks within a Docker container to ensure consistency and portability across different environments.

- **.NET 8 Compatibility**: Built with .NET 8, supporting the latest features and optimizations for string manipulation in C#.

## FAQ

#### How can I customize benchmark parameters?

You can customize benchmark parameters such as the number of repetitions or specific configurations by modifying the `StringManipulationBenchmarks` class in the `StringManipulationBenchmarks.cs` file. Adjust these parameters to simulate different workload scenarios and optimize performance accordingly.

## Support

Reach out to the maintainer at one of the following places:

- [GitHub issues](https://github.com/HamidMolareza/StringBenchmarker/issues/new?assignees=&labels=question&template=SUPPORT_QUESTION.md&title=support%3A+)
- Contact options listed on [this GitHub profile](https://github.com/HamidMolareza)

## Related

BenchmarkDotNet is the underlying framework used by StringBenchmarker for performance benchmarking. Visit the [BenchmarkDotNet GitHub repository](https://github.com/dotnet/BenchmarkDotNet) for documentation, tutorials, and additional resources.

## License

This project is licensed under the **GPLv3**.

See [LICENSE](LICENSE) for more information.

