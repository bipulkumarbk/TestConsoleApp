using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    abstract  class TestAbstract
    {
        public void HelloMethod()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
        public abstract void TestAbstMed();
    }
}
