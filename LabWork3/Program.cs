using System;

namespace LabWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список бабочек: ");
            Butterfly butterfly = new Butterfly("Бабочка", "Красный", "Капуста", "15 дней");
            Console.WriteLine(butterfly.PrintValues());

            Butterfly butterfly1 = new Butterfly("Бабочка", "Синий", "Цветы", "12 дней");
            Console.WriteLine(butterfly1.PrintValues());
            Console.ReadLine();
        }
    }
}
