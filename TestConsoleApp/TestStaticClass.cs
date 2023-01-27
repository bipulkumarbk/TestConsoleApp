using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class TestStaticClass
    {
        static TestStaticClass()
        {
            Console.WriteLine("I am TestStaticClass static constructor");
            Console.ReadLine();
        }
        public TestStaticClass()
        {
            Console.WriteLine("I am TestStaticClass constructor");
            Console.ReadLine();
        }

        public virtual void Test()
        {

        }
    }
    class TestSatic :TestStaticClass
    {
        static TestSatic()
        {
            Console.WriteLine("I am TestStatic static constructor");
            Console.ReadLine();
        }
        public TestSatic()
        {
            Console.WriteLine("I am TestStatic constructor");
            Console.ReadLine();
        }
    }

    class Geeks
    {

        // Static variable
        static int s;

        // Non-static variable
        int ns;

        // Declaration of
        // static constructor
        static Geeks()
        {
            Console.WriteLine("It is static constructor");
            Console.ReadLine();
        }

        // Declaration of
        // non-static constructor
        public Geeks()
        {
            Console.WriteLine("It is non-static constructor");
            Console.ReadLine();
        }
      
    }
}
