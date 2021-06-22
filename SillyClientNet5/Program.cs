using System;
using Framework1;
using Framework2;
using Framework3;

namespace SillyClientNet5
{
    class Program
    {
        static void Main(string[] args)
        {
            var libraryVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo("Library.dll").FileVersion;
            Console.WriteLine($"Loaded Library.dll version: {libraryVersion}");

            try
            {
                var framework1 = new SimpleService();
                var framework2 = new SuperService();
                var framework3 = new WowService();

                framework1.PrintSomethingSimple();
                framework2.PrintSomethingSuper();
                framework3.PrintSomethingWow();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            Console.ReadKey();
        }
    }
}
