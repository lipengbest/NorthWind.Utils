using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthWind.Utils;

namespace NorthWind.Utils.UnitTest
{
    [TestClass]
    public class TextReaderExTest
    {
        [TestMethod]
        public void TestReadLine()
        {
            var line = Console.In.ReadLineNewLine();
            Console.WriteLine($"the input: {line}");
            Console.WriteLine($"the length of line: {line.Length}");

            var newLine = line.RemoveNewLine();
            Console.WriteLine($"newline is: {newLine}");
            Assert.IsTrue(line.Length > newLine.Length);
        }
    }
}
