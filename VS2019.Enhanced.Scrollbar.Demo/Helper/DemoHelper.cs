using System;
using VS2019.Enhanced.Scrollbar.Demo.Interfaces;
using static System.Console;

namespace VS2019.Enhanced.Scrollbar.Demo.Helper
{
    public class DemoHelper
    {

        public DemoHelper ShowDemoOf(IDataTypeDemo dataTypeDemo, ConsoleColor foreGroundColor)
        {
            ForegroundColor = foreGroundColor;

            WriteLine($"==================== {dataTypeDemo.Title} ====================\n");

            dataTypeDemo.ShowDemo();

            WriteLine($"\n-------------------- {dataTypeDemo.Title} --------------------\n");

            return this;
        }

    }

}
