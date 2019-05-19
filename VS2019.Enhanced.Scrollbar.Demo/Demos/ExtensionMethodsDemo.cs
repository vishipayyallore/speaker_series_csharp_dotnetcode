using VS2019.Enhanced.Scrollbar.Demo.Interfaces;
using static System.Console;

namespace VS2019.Enhanced.Scrollbar.Demo.Demos
{
    public class ExtensionMethodsDemo : IDataTypeDemo
    {
        public string Title => GetType().Name;

        public void ShowDemo()
        {
            string input = "125";
            var (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");

            input = "125.45";
            (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");

            input = "ABC";
            (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");
        }
    }

}
