using System.Threading;
using System.Threading.Tasks;

namespace _2019Test
{
    class Program
    {
        static async Task Main()
        {
            var patternExample = new Patterns.PatternExample();
            patternExample.TryMeOut();

            var asyncEnumeratorExample = new Async.AsyncExamples();

            var task = Task.Run(() => asyncEnumeratorExample.TryOutAsyncEnumeralbeAsync());
            var secondTask = Task.Run(() => asyncEnumeratorExample.TryOutAsyncEnumeralbeAsync());

            await Task.WhenAll(task, secondTask);
        }
    }
}
