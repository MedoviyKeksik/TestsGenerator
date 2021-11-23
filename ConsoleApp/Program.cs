using System;
using UnitTestsGeneratorLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratorConfig generatorConfig = new GeneratorConfig
            {
                EndpointFolder = @"D:\Projects\SPP\UnitTestsGenerator\SampleLibrary.Tests\",
                MaxParallelLoadCount = 1,
                MaxParallelExecCount = 1,
                MaxParallelWriteCount = 1
            };
            generatorConfig.Filenames.Add(@"D:\Projects\SPP\UnitTestsGenerator\SampleLibrary\ClassA.cs");
            generatorConfig.Filenames.Add(@"D:\Projects\SPP\UnitTestsGenerator\SampleLibrary\ClassB.cs");
            IUnitTestsGenerator unitTestsGenerator = new UnitTestsGenerator();
            unitTestsGenerator.GenerateTests(generatorConfig).Wait();
        }
    }
}
