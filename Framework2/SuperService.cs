using System;
using Library;

namespace Framework2
{
    public class SuperService
    {
        private readonly Printer _printer;

        public SuperService()
        {
            _printer = new Printer();
        }

        public void PrintSomethingSuper()
        {
            _printer.Print();
        }
    }
}
