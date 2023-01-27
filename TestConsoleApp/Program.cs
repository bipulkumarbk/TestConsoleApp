using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
   
    class ImplementTest: TestAbstract
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
        static Program()
        {
            Console.WriteLine("I am static constructor");
            Console.ReadLine();
        }
        //Program()
        //{
        //    Console.WriteLine("I am Program constructor");
        //    Console.ReadLine();
        //}

        void Add()
        {
            Console.WriteLine("I am Adding number");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            ImplementTest test = new ImplementTest();

            test.HelloMethod();
            test.TestAbstMed();

            TestSealdClass Stest = new TestSealdClass();

            Stest.SealedMethod();


            NotsealedClass testNS = new NotsealedClass();

            testNS.NotsealedMethod();

            //TestSealdClass Teststatic = new TestStaticClass();

            Program pro = new Program();

            pro.Add();

            Geeks geeks = new Geeks();

            TestSatic testSatic = new TestSatic();

        }
    }
}
