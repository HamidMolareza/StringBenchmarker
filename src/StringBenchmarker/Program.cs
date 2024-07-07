using BenchmarkDotNet.Running;
using StringBenchmarker;

var summary = BenchmarkRunner.Run<StringManipulationBenchmarks>();