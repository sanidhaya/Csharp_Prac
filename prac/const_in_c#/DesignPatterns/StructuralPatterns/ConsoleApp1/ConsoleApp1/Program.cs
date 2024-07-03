using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .CreateLogger();

            Log.Information("Hello world");

            int a = 10, b= 0;
            try
            {
                Log.Debug($"Dividing {a} by {b}");
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "something went wrong");
            }
            finally {
                Log.CloseAndFlush();
            }
        }
    }
}
