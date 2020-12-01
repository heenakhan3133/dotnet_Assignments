using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 o = new class1();
            Console.WriteLine(o.add());
            Console.WriteLine(o.add(10,20));
            Console.WriteLine(o.add(10,20,30));
            Console.WriteLine(o.add(10,20,30 ,40));
            Console.WriteLine(o.add(d: 40,a:20));
            Console.ReadLine();

        }
    }

    public class class1
    {
        public int add(int a=0,int b=0,int c=0,int d=0)
        {
            return a+b+c+d;
        }
    }
}
