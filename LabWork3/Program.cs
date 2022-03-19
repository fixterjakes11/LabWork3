using System;

namespace LabWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Butterfly butterfly = new Butterfly("Бабочка", "Red");
            Console.WriteLine(butterfly.PrintValues());

            Butterfly butterfly1 = new Butterfly("Бабочка", "Blue", "Цветы", "12 day");
            Console.WriteLine(butterfly1.PrintValues());
        }
    }
}
