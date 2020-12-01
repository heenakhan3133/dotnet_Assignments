using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objCalling
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 o;
            o = new class1();
            o.display();
            Console.ReadLine();

        }
    }

    public class class1
    {
        public void display()
        {
            Console.WriteLine("Hello world");
        }
    }
}


