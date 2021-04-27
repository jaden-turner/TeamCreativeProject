using System;
using Controller;

namespace Tests
{
    class SSClientTests
    {
        static SpreadsheetController controller;

        /// <summary>
        /// The entry point of the testing program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            controller = new SpreadsheetController();
            Console.WriteLine("Hello World!");
        }
    }
}
