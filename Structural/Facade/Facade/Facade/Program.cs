using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchEngine = new SearchEngineFacade();
            var searchingResult = searchEngine.GetSearchingResult("My test query");

            Console.WriteLine(searchingResult);
            Console.ReadKey();
        }
    }
}
