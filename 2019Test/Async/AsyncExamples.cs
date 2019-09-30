using System;

namespace _2019Test.Async
{
    public class AsyncExamples
    {
        public async System.Threading.Tasks.Task TryOutAsyncEnumeralbeAsync()
        {
            var fastEnumerator = new FastEnumerator();

            int counter = 1;
            await foreach(var workHouseItem in fastEnumerator.GetAllWorkhouseItemsAsync())
            {
                Console.WriteLine($"Fetched item {workHouseItem.AmountOnShelf}");
                Console.WriteLine($"Number {counter}");
                counter++;
            }
            
        }
    }
}
