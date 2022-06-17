using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //zip compress
            CompressionContext compressionContext = new CompressionContext(new ZipCompression());
            compressionContext.CreateArchive("DotnetHelloWorld");

            Console.WriteLine();

            //rar compress
            compressionContext.SetStrategy(new RarCompression());
            compressionContext.CreateArchive("DotnetHelloWorld");

            Console.ReadKey();
        }
    }
}
