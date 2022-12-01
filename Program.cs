using System;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task<int> addAsync(int a, int b)
        {
            await Task.Delay(100);
            return a + b;
        }
        static void Main(string[] args)
        {
            int total = Helpers.AsyncHelper.RunSync<int>(() => addAsync(1, 2));
            Console.WriteLine(total);
        }
    }
}