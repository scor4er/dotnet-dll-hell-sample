using Library;

namespace Framework1
{
    public class SimpleService
    {
        private readonly Printer _printer;

        public SimpleService()
        {
            _printer = new Printer();
        }

        public void PrintSomethingSimple()
        {
            _printer.Print();
        }
    }
}
