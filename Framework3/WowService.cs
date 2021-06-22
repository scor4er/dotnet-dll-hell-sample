using Library;

namespace Framework3
{
    public class WowService
    {
        private readonly Printer _printer;

        public WowService()
        {
            _printer = new Printer();
        }

        public void PrintSomethingWow()
        {
            _printer.Print("Wow Such Business Logic!");
        }
    }
}
