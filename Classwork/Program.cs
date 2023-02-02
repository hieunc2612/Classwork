using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Nguyen Van A";
            p.Age = 20;
            System.Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
