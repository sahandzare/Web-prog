using RestSharp;
using System.Runtime;
using System.Threading;
namespace Async
{
    public class Program
    {
        private const string URL = "https://docs.microsoft.com/en-us/dotnet/csharp";
        public static void DoSynchronousWork()
        {
            Console.WriteLine("1.sync work");
        }
        static  async Task DoSomethingAsync()
        {
            Console.WriteLine("2.do something");

            await GetStringAsync();
        }


        static void Main(string[] args)
        {
           
                DoSynchronousWork();
                var someTask = DoSomethingAsync();
                DoSynchronousWorkAfterAwait();
                someTask.Wait(); //this is a blocking call, use it only on Main method
            
        }
        static async Task GetStringAsync()
        {
            using (var httpClient = new HttpClient())
            {
                Console.WriteLine("3.awaiting the result");
                string result = await httpClient.GetStringAsync(URL);//execute
                Console.WriteLine("4.awaiting task completed");
                Console.WriteLine($"5.the length of the http get for the {URL}");
                Console.WriteLine($"{result.Length} character");

            }
        }
        static async Task DoSynchronousWorkAfterAwait()
        {
            // this is the wrk that we can do wile waiting for you awaited async task

            Console.WriteLine("7.while waiting for the async task to finish we can see somethings");

            for(var i = 0; i <= 5; i++)
            {
             for(var j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }


        }
    }
}