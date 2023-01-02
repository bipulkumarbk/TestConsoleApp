using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    abstract class TestAbst
    {
        public void TestMed()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
        public abstract void TestAbstMed();
       
    }

    class ImplementTest:TestAbst
    {
        public override void TestAbstMed()
        {
            Console.WriteLine("Hello World I am Abstract");
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementTest test = new ImplementTest();

            test.TestMed();
            test.TestAbstMed();

                 
        }
    }
}
