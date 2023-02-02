using System.Xml.Linq;

namespace Classwork
{
    internal class Person
    {
        string name;
        int age;
        public string Name { get => name; set => name = value; }
        public int Age
        {
            get => age;
            set
            {
                if (value > 0) age = value;
                else System.Console.WriteLine("Age cannot negative ");
            }
        }

        //Auto Property
        // public string Name { get; set; }
        // public string Name { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "; Age: " + Age;
        }
    }
}
