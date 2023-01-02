using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    sealed class TestSealdClass
    {
        public void SealedMethod()
        {
            Console.WriteLine("I am sealed Class method.");
            Console.ReadLine();
        }

    }

    class NotsealedClass
    {
        public virtual void NotsealedMethod()
        {
            Console.WriteLine("I am not sealed Class method.");
            Console.ReadLine();
        }
    }
}
