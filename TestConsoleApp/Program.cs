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

    class Testseadled : NotsealedClass
    {
        public override void NotsealedMethod()
        {
            base.NotsealedMethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementTest test = new ImplementTest();

            test.TestMed();
            test.TestAbstMed();

            TestSealdClass Stest = new TestSealdClass();

            Stest.SealedMethod();


            NotsealedClass testNS = new NotsealedClass();

            testNS.NotsealedMethod();
        }
    }
}
